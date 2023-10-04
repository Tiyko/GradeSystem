using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.Reflection;
using System.Xml.Linq;
using System.Xml;

namespace GradeSystem
{
    public class Data
    {
        public static string RootDir { get; set; }
        static readonly string connectionString = ConfigurationManager.AppSettings["connectingString"];

        public static string ErrLogFilePath = GetRootDir() + "\\Logs\\Error.log";
        public static string SqlLogFilePath = GetRootDir() + "\\Logs\\SqlLog.log";
        public static string ErrLoc;
        public static string ErrMsg;


        //  Retrieve a list of rows from the Database.
        public static List<T> GetData<T>(string SQL)
        {
            WriteToSqlLog(SQL);
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                var objProps = Activator.CreateInstance<T>().GetType().GetProperties();
                var returnList = new List<T>();

                using (SqlCommand cmd = new SqlCommand(SQL, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandTimeout = 30000;

                    try
                    {
                        cnn.Open();

                        SqlDataReader reader = cmd.ExecuteReader(); // Rerieves multiple records;

                        var columns = reader.GetSchemaTable().Rows.Cast<DataRow>().Select(row => row["ColumnName"].ToString().ToLower()).ToList();

                        while (reader.Read())
                        {
                            var thisRow = Activator.CreateInstance<T>();
                            foreach (var prop in objProps)
                            {
                                if (columns.Contains(prop.Name.ToLower()))
                                {
                                    if (reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                                    {
                                        prop.SetValue(thisRow, null, null);
                                    }
                                    else
                                    {
                                        prop.SetValue(thisRow, reader[prop.Name], null);
                                    }
                                }
                            }
                            returnList.Add(thisRow);
                        }
                    }
                    catch (Exception ex)
                    {
                        ErrLoc = "Data.GetData";
                        ErrMsg = ex.Message;
                        WriteToErrorLog();
                        throw ex;
                    }
                    finally
                    {
                        if (cnn.State != ConnectionState.Closed)
                        {
                            cnn.Close();
                        }
                    }
                }
                return returnList;
            }
        }

        //  ExecuteNonQuery() - can be used for inserts, updates and deletes on the Database.
        public static int ExecuteSqlNonQuery(string sql)
        {
            WriteToSqlLog(sql);
            int num = 0;
            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandTimeout = 30000;

                        cnn.Open();

                        num = cmd.ExecuteNonQuery();
                    }
                }

            }
            catch (SqlException ex)
            {
                ErrLoc = "Data.ExecuteSqlNonQuery";
                ErrMsg = ex.Message;
                WriteToErrorLog();
            }
            return num;
        }

        // POLYMORPHISM - an overloaded method to allow inserts, updates and deletes allowing us
        //                to use stored procedures

        public static int ExecuteSqlNonQuery(string sqlGetAndStoredProcedures, Dictionary<string, object> parameters = null, CommandType cmdType = CommandType.Text)
        {
            WriteToSqlLog(sqlGetAndStoredProcedures);
            int num = 0;
            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sqlGetAndStoredProcedures, cnn))
                    {
                        cmd.CommandType = cmdType;
                        cmd.CommandTimeout = 30000;

                        if (parameters != null)
                        {
                            foreach (var item in parameters)
                            {
                                cmd.Parameters.AddWithValue(item.Key, item.Value);
                            }
                        }

                        cnn.Open();

                        num = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrLoc = "Data.ExecuteSqlNonQuery(string sqlGetAndStoredProcedures";
                ErrMsg = ex.Message;
                WriteToErrorLog();
            }
            return num;
        }

        //  Retieves a single value. returns the value in the first column of the first row from the resultset.
        public static string ExecuteSqlScalar(string sql)
        {
            WriteToSqlLog(sql);

            string res = "";
            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandTimeout = 30000;

                        cnn.Open();

                        var sqlResult = cmd.ExecuteScalar();

                        res = sqlResult.ToString();
                    }
                }
                return res;
            }
            catch (SqlException ex)
            {
                ErrLoc = "Data.ExecuteSqlScalar";
                ErrMsg = ex.Message;
                WriteToErrorLog();
            }
            return res;
        }


        public static void WriteToErrorLog()
        {
            string details = $"Time: {DateTime.Now} - Error Location: {ErrLoc} - Error Message: {ErrMsg}\n";

            File.AppendAllText(ErrLogFilePath, details);
        }

        public static void WriteToSqlLog(string sql)
        {
            string details = $"Time: {DateTime.Now} - Statement: {sql}\n";

            File.AppendAllText(SqlLogFilePath, details);
        }

        public static List<T> ImportFromCSV<T>(string filePath)
        {
            List<T> items = new List<T>();

            try
            {
                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    var mapping = GetTypeMapping<T>();
                    csv.Context.RegisterClassMap(mapping);
                    items = csv.GetRecords<T>().ToList();
                }
            }
            catch (Exception ex)
            {
                ErrLoc = "Data.ImportFromCSV";
                ErrMsg = ex.Message;
                throw;
            }


            return items;
        }

        public static string InsertObjectsFromCsv<T>(string filePath)
        {
            string tableName = typeof(T).Name;
            string res = $"Failed to insert {tableName}";
            try
            {
                // Import objects from CSV
                List<T> objects = ImportFromCSV<T>(filePath);

                foreach (T obj in objects)
                {
                    // Generate SQL insert statement based on the CSV headers and type name

                    string insertSql = GenerateInsertSql(obj, tableName);

                    // Define a dictionary to hold parameter names and values
                    Dictionary<string, object> parameters = new Dictionary<string, object>();

                    // Populate the parameters dictionary based on obj properties
                    foreach (var prop in obj.GetType().GetProperties())
                    {
                        parameters["@" + prop.Name] = prop.GetValue(obj) ?? DBNull.Value;
                    }

                    // Execute the insert statement with parameters
                    int rowsInserted = ExecuteSqlNonQuery(insertSql, parameters);

                    if (rowsInserted > 0)
                    {
                        res = $"{tableName} inserted successfully.";
                    }
                }
            }
            catch (Exception ex)
            {
                ErrLoc = "Data.InsertObjectsFromCsv()";
                ErrMsg = ex.Message;
                WriteToErrorLog();
            }
            return res;
        }

        private static string GenerateInsertSql<T>(T obj, string tableName, string format = "csv")
        {
            var properties = obj.GetType().GetProperties();
            var identityColumnName = GetIDColumnName(tableName);


            // Filter out identity properties based on the dynamically retrieved identity column name
            var nonIdProperties = properties.Where(prop => prop.Name.ToLower() != identityColumnName.ToLower());

            var csvHeaders = string.Join(", ", nonIdProperties.Select(prop => prop.Name));
            var csvValues = string.Join(", ", nonIdProperties.Select(prop => $"@{prop.Name}"));

            return $"INSERT INTO {tableName} ({csvHeaders}) VALUES ({csvValues})";
        }



        private static string GetIDColumnName(string tableName)
        {
            string identityColumnName = null;

            string sql = $@"
                SELECT COLUMN_NAME
                FROM INFORMATION_SCHEMA.COLUMNS
                WHERE TABLE_SCHEMA = 'dbo'
                AND COLUMNPROPERTY(object_id(TABLE_NAME), COLUMN_NAME, 'IsIdentity') = 1
                AND TABLE_NAME = '{tableName}'";


            identityColumnName = ExecuteSqlScalar(sql);

            return identityColumnName;
        }

        private static ClassMap GetTypeMapping<T>(string format = "csv")
        {
            if (format == "csv")
            {
                if (typeof(T) == typeof(Teacher))
                {
                    return new TeacherMap();
                }
                else if (typeof(T) == typeof(Student))
                {
                    return new StudentMap();
                }
                else if (typeof(T) == typeof(Module))
                {
                    return new ModuleMap();
                }
                else if (typeof(T) == typeof(Grade))
                {
                    return new GradeMap();
                }
                else
                {
                    throw new NotSupportedException($"Mapping for type {typeof(T).Name} not supported.");
                }
            }
            else if (format == "xml")
            {
                if (typeof(T) == typeof(Teacher))
                {
                    return new TeacherXmlMap();
                }
                else if (typeof(T) == typeof(Student))
                {
                    return new StudentXmlMap();
                }
                else if (typeof(T) == typeof(Module))
                {
                    return new ModuleXmlMap();
                }
                else if (typeof(T) == typeof(Grade))
                {
                    return new GradeXmlMap();
                }
                else
                {
                    throw new NotSupportedException($"Mapping for type {typeof(T).Name} not supported.");
                }
            }
            else
            {
                throw new NotSupportedException($"File type {format} not supported.");
            }
        }


        public static List<T> ImportFromXml<T>(string filePath)
        {
            List<T> objs = new List<T>();

            try
            {
                XDocument document = XDocument.Load(filePath);
                XElement root = document.Root;

                foreach (XElement element in root.Elements(typeof(T).Name))
                {
                    T obj = (T)Activator.CreateInstance(typeof(T));

                    foreach (var prop in typeof(T).GetProperties())
                    {
                        XElement xmlElement = element.Element(prop.Name);

                        if (xmlElement != null)
                        {
                            object propValue = null;

                            if (prop.PropertyType == typeof(int))
                            {
                                propValue = int.Parse(xmlElement.Value);
                            }
                            else if (prop.PropertyType == typeof(string))
                            {
                                propValue = xmlElement.Value;
                            }
                            // Add more type checks as needed for other property types

                            prop.SetValue(obj, propValue);
                        }
                    }

                    objs.Add(obj);
                }
            }
            catch (Exception ex)
            {
                ErrLoc = "Data.ImportFromXml()";
                ErrMsg = "Error reading XML data: " + ex.Message;
                WriteToErrorLog();
            }

            return objs;
        }

        public static string InsertObjectsFromXml<T>(string filePath, ClassMap<T> mapping = null)
        {
            string tableName = typeof(T).Name;
            string res = $"Failed to insert {tableName} \n";
            try
            {
                // Import objects from CSV
                List<T> objs = ImportFromXml<T>(filePath);

                foreach (T obj in objs)
                {
                    // Generate SQL insert statement
                    string insertSql = GenerateInsertSql(obj, tableName, "xml");

                    // Define a dictionary to hold parameter names and values
                    Dictionary<string, object> parameters = new Dictionary<string, object>();

                    // Populate the parameters dictionary based on obj properties
                    foreach (var prop in obj.GetType().GetProperties())
                    {
                        parameters["@" + prop.Name] = prop.GetValue(obj) ?? DBNull.Value;
                    }

                    // Execute the insert statement with parameters
                    int rowsInserted = ExecuteSqlNonQuery(insertSql, parameters);

                    if (rowsInserted > 0)
                    {
                        res = $"{tableName} inserted successfully.";
                    }
                }
            }
            catch (Exception ex)
            {
                ErrLoc = "Data.InsertObjectsFromXml()";
                ErrMsg = ex.Message;
                WriteToErrorLog();
            }
            return res;
        }

        public static void GenerateXmlFile<T>(List<T> objs, string filePath, bool append = false)
        {
            string tableName = typeof(T).Name;
            string identityColumnName = GetIDColumnName(tableName);

            XElement root;


            if (append && File.Exists(filePath))
            {
                // Load the existing XML file
                XDocument existingDocument = XDocument.Load(filePath);
                root = existingDocument.Root;
            }
            else
            {
                root = new XElement(tableName + "s");
            }

            foreach (T obj in objs)
            {
                XElement objElement = new XElement(tableName);

                // Use reflection to access and add properties dynamically
                foreach (PropertyInfo prop in typeof(T).GetProperties())
                {
                    // Check if the property is an identity property
                    bool isIdentity = string.Equals(prop.Name, identityColumnName, StringComparison.OrdinalIgnoreCase);

                    // Exclude identity properties from the XML
                    if (!isIdentity)
                    {
                        object value = prop.GetValue(obj);
                        objElement.Add(new XElement(prop.Name, value));
                    }
                }

                root.Add(objElement);
            }

            XDocument document = new XDocument(root);

            using (XmlWriter writer = XmlWriter.Create(filePath, new XmlWriterSettings { Indent = true }))
            {
                document.Save(writer);
            }
        }


        public static void GenerateCsvFile<T>(List<T> objs, string filePath, bool append = false)
        {
            if (!append || !File.Exists(filePath))
            {
                using (var writer = new StreamWriter(filePath))
                using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    csv.WriteRecords(objs);
                }
            }
            else
            {
                using (var writer = new StreamWriter(filePath, append: true))
                using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    csv.WriteRecords(objs);
                }
            }
        }










        public static string GetRootDir() 
        {
            // Get the filepath to the executable file for this app
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var d = System.IO.Path.GetDirectoryName(path);
            var dir = d.Replace("\\bin\\Debug", "");

            RootDir = dir;
            return RootDir;
        }
    }
}
