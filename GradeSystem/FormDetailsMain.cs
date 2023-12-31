﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GradeSystem
{
    public partial class FormDetailsMain : Form
    {
        // Fields
        // Fields to store the user's status, user ID, and module ID
        public string Stat = "TEACHER";
        public string ID = "0";
        public string ModID = "0";


        // Constructors
        public FormDetailsMain()
        {
            InitializeComponent(); // function that initializes the designer class with the content of the form.
        }


        // Events
        // Event handler for when the form is loaded
        private void FormDetailsMain_Load(object sender, EventArgs e)
        {
            // Get the root directory, insert teacher and student data from CSV files
            Data.GetRootDir();
            string res = "";

            res = Data.InsertObjectsFromCsv<Teacher>(Data.RootDir + "\\Teacher\\InitTeachers.csv");
            LBLinfo.Text += res + "\n";

            res = Data.InsertObjectsFromCsv<Student>(Data.RootDir + "\\Student\\InitStudents.csv");
            LBLinfo.Text += res + "\n";

            // Populate the CheckedListBox with a list of teachers from the database
            LoadPersonDetails(Stat);
            AssignModules();
            GenerateGradeFiles();
        }

        // Event handler for radio button selection to change the user status
        private void RBstatus_CheckedChanged(object sender, EventArgs e)
        {
            // Reset user and module IDs
            ID = "0";
            ModID = "0";

            if (RBteacher.Checked)
            {
                // If the "Teacher" radio button is checked
                this.Text = "Teacher Details";
                LBLperson.Text = "Select Teacher";
                Stat = "TEACHER";

                BTNadd.Text = "NEW TEACHER";
                BTNupdate.Text = "UPDATE TEACHER";

                ShowStudentComponents(false);
                LoadSelectedStudentGrade();

                TXTBfirstName.Clear();
                TXTBlastName.Clear();
            }
            else
            {
                // If the "Student" radio button is checked
                this.Text = "Student Details";
                LBLperson.Text = "Select Student";
                Stat = "STUDENT";

                BTNadd.Text = "NEW STUDENT";
                BTNupdate.Text = "UPDATE STUDENT";

                ShowStudentComponents(true);
                LoadModules();

                TXTBfirstName.Clear();
                TXTBlastName.Clear();
            }

            EnableAddButton(true);
            SetTextBoxReadOnly(true);
            Utils.ClearAllFields(this);
            EnableUpdateDeleteButtons(false, ListType.Both);
            LoadPersonDetails(Stat);
        }

        // Event handler to clear the file input text box when CSV is selected
        private void RBcsv_CheckedChanged(object sender, EventArgs e)
        {
            TXTBfile.Clear();
        }

        // Event handler to clear the file input text box when XML is selected
        private void RBxml_CheckedChanged(object sender, EventArgs e)
        {
            TXTBfile.Clear();
        }

        // Event handler for CheckedListBox item selection (loads module or grade details)
        private void CLB_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox listBox = (CheckedListBox)sender;

            string clbName = listBox.Name;
            ListType lType = ListType.Detail;

            if (clbName == "CLBdetails")
            {
                lType = ListType.Detail;
            }
            else if (clbName == "CLBmodules")
            {
                lType = ListType.Module;
            }

            // Uncheck other items when a new item is checked
            if (e.NewValue == CheckState.Checked)
            {
                for (int i = 0; i < listBox.Items.Count; i++)
                {
                    listBox.SetItemChecked(i, false);
                }
                EnableUpdateDeleteButtons(true, lType);
            }
            else
            {
                EnableUpdateDeleteButtons(false, lType);
            }
        }

        // Event handler for CheckedListBox item selection (loads details or modules)
        private void CLBdetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSelectedDetails();
            if (Stat == "STUDENT")
            {
                LoadSelectedStudentGrade();
            }
            else
            {
                LoadModules();
            }
            SetAddButtonStateNew();
        }

        // Event handler for CheckedListBox item selection (loads module details)
        private void CLBmoduleDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSelectedModuleDetails();
        }

        // Event handler for the "Add" button (adding a new teacher or student)
        private void BTNadd_Click(object sender, EventArgs e)
        {
            string buttonState = BTNadd.Text;
            int numRowsAffected = 0;

            if (buttonState == "NEW " + Stat)
            {
                SetAddButtonStateSave();
            }
            else
            {
                if (Stat == "TEACHER")
                    numRowsAffected = AddTeacher();
                else
                    numRowsAffected = AddStudent();

                if (numRowsAffected > 0)
                {
                    MessageBox.Show("A New " + Stat + " has been added.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    LoadPersonDetails(Stat);
                    SetAddButtonStateNew();
                }
                else
                {
                    MessageBox.Show("Fail!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
        }

        // Event handler for the "Update" button (updating teacher or student information)
        private void BTNupdate_Click(object sender, EventArgs e)
        {

            //int res = 0;
            //string sql = "";


            //if (TXTBfirstName.TextLength > 0 && TXTBlastName.TextLength > 0)
            //{
            //    ID = Utils.GetSelectedID(CLBdetails);
            //    sql = "update " + Stat + " set fName = '" + TXTBfirstName.Text + "' " +
            //            "lName = " + TXTBlastName + "' " + "where " + Stat + "ID = '" + ID + "'";

            //}
            //else
            //{
            //    LBLinfo.ForeColor = Color.Red;
            //    LBLinfo.Text = "Please make sure first and last name fields are populated";
            //}

            //res = Data.ExecuteSqlNonQuery(sql);
            //LoadPersonDetails(Stat);
            //Utils.ClearAllFields(this);






            string buttonState = BTNupdate.Text;
            int numRowsAffected = 0;

            if (buttonState == "UPDATE " + Stat)
            {
                SetUpdateButtonStateSave();
            }
            else
            {
                if (Stat == "TEACHER")
                    numRowsAffected = UpdateTeacher();
                else
                    numRowsAffected = UpdateStudent();

                if (numRowsAffected > 0)
                {
                    MessageBox.Show(Stat + " has been updated.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    LoadPersonDetails(Stat);
                    SetUpdateButtonStateUpdate();
                }
                else
                {
                    MessageBox.Show("Fail!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
        }

        // Event handler for selecting a file to import (CSV or XML)
        private void BTNfile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                string filePath = Data.GetRootDir() + "\\Grade\\";
                if (RBcsv.Checked)
                {
                    dlg.Title = "Select CSV File!";
                    dlg.Filter = "CSV Files (*.csv)|*.csv";
                }
                else if (RBxml.Checked)
                {
                    dlg.Title = "Select XML File!";
                    dlg.Filter = "XML Files (*.xml)|*.xml";
                }

                dlg.InitialDirectory = filePath;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    var file = dlg.FileName.Replace(filePath, "");
                    TXTBfile.Text = file;
                    BTNimport.Enabled = true;
                }
            }
        }

        // Event handler for importing a CSV or XML file (grades)
        private void BTNimport_Click(object sender, EventArgs e)
        {
            string res = "";
            string filePath = Data.GetRootDir() + "\\Grade\\";
            if (TXTBfile.TextLength > 0)
            {
                filePath += TXTBfile.Text;
                if (RBcsv.Checked)
                {
                    TXTBfile.Clear();
                    res = Data.InsertObjectsFromCsv<Grade>(filePath);
                }
                else if (RBxml.Checked)
                {
                    TXTBfile.Clear();
                    res = Data.InsertObjectsFromXml<Grade>(filePath);
                }
            }
            LBLinfo.Text += res + "\n";
        }

        // Event handler for closing the application (confirmation dialog)
        private void BTNclose_Click(object sender, EventArgs e)
        {
            DialogResult dlgRes = new DialogResult();
            dlgRes = MessageBox.Show("Are you sure you want to exit?", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dlgRes == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        // Event handler for text changes in the input fields (enables the "Add" button)
        private void TXTB_TextChanged(object sender, EventArgs e)
        {
            if ((TXTBfirstName.TextLength > 0 && TXTBlastName.TextLength > 0 && BTNadd.Text == "SAVE " + Stat) || BTNadd.Text == "NEW " + Stat)
            {
                EnableAddButton(true);
            }
            else
            {
                EnableAddButton(false);
            }
        }


        // Helper methods
        // Helper method to load person details (teachers or students) from the database
        public void LoadPersonDetails(string personType) // function to query the database and select a table depending on necessity
        {
            string sql = "select * from " + personType; // query the database and store the details in a variable
            Utils.LoadListBox(CLBdetails, sql, Stat); // populates the form CheckListBox with the details from the database
        }

        // Helper method to load selected details (teacher or student)
        private void LoadSelectedDetails()
        {
            // variables to store the details retrieved from the database
            string id = "0";
            string fName = "";
            string lName = "";
            string sql = "";

            id = Utils.GetSelectedID(CLBdetails); // load and store the selected id from the User (CheckListBox)
            sql = "select * from " + Stat + " where " + Stat + "id = '" + id + "'"; // query the database and store in a variable

            // if else statements that check and display information to the CheckListBox
            // depending on which radio button has been pressed 
            if (Stat == "TEACHER")
            {
                var teacherInfo = Data.GetData<Teacher>(sql); // gets and stores the Teacher table from the database
                if (teacherInfo.Count > 0) // selects a teacher from the list if the count is greater than 0
                {
                    var teach = teacherInfo[0]; // sets the position in the array to 0
                    Teacher teacher = new Teacher(teach.TeacherID, teach.FName, teach.LName);
                    fName = teacher.FName;
                    lName = teacher.LName;
                }
            }
            else if (Stat == "STUDENT")
            {
                var studentInfo = Data.GetData<Student>(sql);
                if (studentInfo.Count > 0)
                {
                    var stud = studentInfo[0];
                    Student student = new Student(stud.StudentID, stud.FName, stud.LName);
                    fName = student.FName;
                    lName = student.LName;
                }
            }

            TXTBfirstName.Text = fName; // display the retrevied and stored information
            TXTBlastName.Text = lName;  // to the form's textboxes, in the curent case
                                        // a student or a teacher's first and last name
        }

        // Method to load module details for students or teachers
        private void LoadSelectedModuleDetails()
        {
            string modName = "";
            string grade = "";
            string sql = "";

            ID = Utils.GetSelectedID(CLBdetails);
            ModID = Utils.GetSelectedID(CLBmodules);
            if (ModID != "")
            {
                sql = "select ModName from Module where ModID = '" + ModID + "'";
                modName = Data.ExecuteSqlScalar(sql);
                TXTBmodule.Text = modName;

                if (Stat == "STUDENT")
                {
                    sql = "select TheGrade from Grade where ModID = '" + ModID + "' " +
                        "and StudentID = '" + ID + "'";
                    grade = Data.ExecuteSqlScalar(sql);
                    TXTBgrade.Text = grade;
                }
            }
            else
            {
                TXTBmodule.Text = "";
                TXTBgrade.Text = "";
            }
        }

        // Method to load student grades and calculate GPA
        private void LoadSelectedStudentGrade()
        {
            string id = Utils.GetSelectedID(CLBdetails);
            string sql = "Select m.ModID, m.ModName, g.TheGrade " +
                            "From Module m " +
                            "Join Grade g On g.ModID = m.ModID " +
                            "Where g.StudentID = '" + id + "'";

            // Clear the CLBModule items
            CLBmodules.Items.Clear();
            TXTBgrade.Text = "";
            TXTBmodule.Text = "";
            var moduleInfo = Data.GetData<Module>(sql);
            var gradeInfo = Data.GetData<Grade>(sql);
            // Load data into CLBModule
            Utils.LoadModListBox(CLBmodules, moduleInfo, gradeInfo);
            CalculateGPA();
        }

        // Method to calculate GPA
        private void CalculateGPA()
        {
            ID = Utils.GetSelectedID(CLBdetails);
            string sql = "select TheGrade From Grade where StudentID = '" + ID + "'";

            var gradeInfo = Data.GetData<Grade>(sql);
            int qty = gradeInfo.Count;

            string letter = "";

            double totalPoints = 0.00D;

            foreach (var grade in gradeInfo)
            {
                letter = grade.TheGrade;
                switch (letter)
                {
                    case "A":
                        totalPoints += 4.00;
                        break;
                    case "B":
                        totalPoints += 4.00;
                        break;
                    case "C":
                        totalPoints += 3.00;
                        break;
                    case "D":
                        totalPoints += 2.00;
                        break;
                    case "E":
                        totalPoints += 0.00;
                        break;
                    case "F":
                        totalPoints += 0.00;
                        break;
                }
            }

            double gpa = totalPoints / qty;

            LBLgpa.Text = $"GPA: {gpa:F2}";
        }

        // Method to change the state of the "Add" button for adding a new user
        private void SetAddButtonStateNew()
        {
            string buttonState = BTNadd.Text;

            if (buttonState == "SAVE " + Stat)
            {
                BTNadd.Text = "NEW " + Stat;
                SetTextBoxReadOnly(true);
                TXTBfirstName.Text = "";
                TXTBfirstName.Text = ""; // clearing fields using an empty string
                TXTBlastName.Clear(); // clearing fields using Clear() function
            }
        }

        // Method to change the state of the "Add" button for saving a new user
        private void SetAddButtonStateSave()
        {
            string buttonState = BTNadd.Text;
            if (buttonState == "NEW " + Stat)
            {
                Utils.UncheckListBoxItems(CLBdetails);
                Utils.ClearAllFields(this);
                LoadSelectedDetails();
                LoadModules();
                SetTextBoxReadOnly(false);
                BTNadd.Text = "SAVE " + Stat;
                BTNadd.Enabled = false;
            }
        }

        // Method to change the state of the "Update" button for updating user information
        private void SetUpdateButtonStateUpdate()
        {
            string buttonState = BTNupdate.Text;

            if (buttonState == "SAVE " + Stat)
            {
                BTNupdate.Text = "UPDATE " + Stat;
                SetTextBoxReadOnly(true);
                TXTBfirstName.Text = "";
                TXTBfirstName.Text = ""; // clearing fields using an empty string
                TXTBlastName.Clear(); // clearing fields using Clear() function
            }
        }

        // Method to change the state of the "Update" button for saving updates
        private void SetUpdateButtonStateSave()
        {
            string buttonState = BTNupdate.Text;
            if (buttonState == "UPDATE " + Stat)
            {
                LoadSelectedDetails();
                LoadModules();
                SetTextBoxReadOnly(false);
                BTNupdate.Text = "SAVE " + Stat;
                BTNupdate.Enabled = true;
                BTNadd.Enabled = false;
            }
        }

        // Method to add a new teacher
        private int AddTeacher()
        {
            string sql = "insert into " + Stat + "(fName, lName) Values('" + TXTBfirstName.Text + "', '" + TXTBlastName.Text + "')";
            int numRowsAffected = Data.ExecuteSqlNonQuery(sql);
            return numRowsAffected;
        }

        // Method to add a new student
        private int AddStudent()
        {
            string storedProcedure = "SP_InsertStudent";
            string fName = TXTBfirstName.Text;
            string lName = TXTBlastName.Text;

            Dictionary<string, object> spParams = new Dictionary<string, object>
            {
                { "@FirstName", fName },
                { "@LastName", lName },
            };

            int numRowsAffected = Data.ExecuteSqlNonQuery(storedProcedure, spParams, CommandType.StoredProcedure);
            return numRowsAffected;
        }

        // Method to update teacher information
        private int UpdateTeacher()
        {
            string storedProcedure = "SP_UpdateTeacher";
            string fName = TXTBfirstName.Text;
            string lName = TXTBlastName.Text;
            string idTeacher = Utils.GetSelectedID(CLBdetails);

            Dictionary<string, object> spParams = new Dictionary<string, object>
            {
                { "@FirstName", fName },
                { "@LastName", lName },
                { "@TeacherID", idTeacher }
            };

            int numRowsAffected = Data.ExecuteSqlNonQuery(storedProcedure, spParams, CommandType.StoredProcedure);
            return numRowsAffected;
        }

        // Method to update student information
        private int UpdateStudent()
        {
            string storedProcedure = "SP_UpdateStudent";
            string fName = TXTBfirstName.Text;
            string lName = TXTBlastName.Text;
            string idStudent = Utils.GetSelectedID(CLBdetails);

            Dictionary<string, object> spParams = new Dictionary<string, object>
            {
                { "@FirstName", fName },
                { "@LastName", lName },
                { "@StudentID", idStudent }
            };

            int numRowsAffected = Data.ExecuteSqlNonQuery(storedProcedure, spParams, CommandType.StoredProcedure);
            return numRowsAffected;
        }

        // Method to enable or disable the "Update" and "Delete" buttons based on the list type (Detail, Module, Both)
        private void EnableUpdateDeleteButtons(bool state, ListType listType = ListType.Detail)
        {
            if (listType == ListType.Detail)
            {
                BTNupdate.Enabled = state;
                TXTBfirstName.ReadOnly = !state;
                TXTBlastName.ReadOnly = !state;
            }
            else if (listType == ListType.Module)
            {
                TXTBmodule.ReadOnly = !state;
                TXTBgrade.ReadOnly = !state;
            }
            else if (listType == ListType.Both)
            {
                BTNupdate.Enabled = state;
                TXTBfirstName.ReadOnly = !state;
                TXTBlastName.ReadOnly = !state;
            }
        }

        // Method to set the read-only state of text boxes
        private void SetTextBoxReadOnly(bool state)
        {
            TXTBfirstName.ReadOnly = state;
            TXTBlastName.ReadOnly = state;
        }

        // Method to enable or disable the "Add" button
        private void EnableAddButton(bool state)
        {
            BTNadd.Enabled = state;
        }

        // Method to show or hide components specific to student details
        private void ShowStudentComponents(bool state)
        {
            LBLgradeName.Visible = state;
            TXTBgrade.Visible = state;
            GBBulk.Visible = state;
        }

        // Method to load modules for a teacher
        private void LoadModules()
        {
            string id = "0";
            id = Utils.GetSelectedID(CLBdetails);
            string sql = "select * from Module where TeacherID = '" + id + "';";

            Utils.LoadListBox(CLBmodules, sql, Stat);
        }

        // Method to assign modules to teachers
        private void AssignModules()
        {
            string res = "";
            string sql = "select TeacherID from Teacher order by TeacherID desc";

            List<int> teacherIds = GetListIds<Teacher>(sql, teacher => teacher.TeacherID);

            List<string> moduleNames = new List<string>
            {
                "Maths", "English", "Irish", "Geography", "History", "Computers", "Science", "Biology", "Art",
                "PE", "Music", "German", "Fench", "Technology"
            };

            List<Module> mods = new List<Module>();

            int tIndex = 0;

            foreach (string module in moduleNames)
            {
                int teacherId = teacherIds[tIndex];
                mods.Add(new Module
                {
                    ModName = module,
                    TeacherID = teacherId
                });

                tIndex = (tIndex + 1) % teacherIds.Count;

                Data.GenerateXmlFile<Module>(mods, Data.GetRootDir() + "\\Module\\modules.xml");
            }

            LBLinfo.Text += "modules.xml file created \n";
            res = Data.InsertObjectsFromXml<Module>(Data.GetRootDir() + "\\Module\\modules.xml");
            LBLinfo.Text += res;
        }

        // Method to generate random grades for students
        private void GenerateGradeFiles()
        {
            try
            {
                string xmlFilePath = Data.RootDir + "\\Grade\\grades.xml";
                string csvFilePath = Data.RootDir + "\\Grade\\grades.csv";
                string sql = "SELECT ModID FROM Module";
                List<int> moduleIds = GetListIds<Module>(sql, module => module.ModID); //modIds from the Module table
                sql = "SELECT StudentID FROM Student";
                List<int> studentIds = GetListIds<Student>(sql, student => student.StudentID); // Get all studentIds from the Student table

                Random rng = new Random();

                List<Grade> grades = new List<Grade>();

                foreach (int studentId in studentIds)
                {
                    List<int> selectedModuleIds = moduleIds
                        .OrderBy(x => rng.Next())
                        .Take(7) // Select 7 random moduleIds
                        .ToList();

                    foreach (int moduleId in selectedModuleIds)
                    {
                        string randomGrade = GenerateRandomGrade(rng);

                        grades.Add(new Grade
                        {
                            TheGrade = randomGrade,
                            ModID = moduleId,
                            StudentID = studentId
                        });
                    }
                }
                // Write grades to CSV
                Data.GenerateCsvFile(grades, csvFilePath);

                // Write grades to XML
                Data.GenerateXmlFile(grades, xmlFilePath);

                LBLinfo.ForeColor = Color.Green;
                LBLinfo.Text += "Grades generated and saved to grades.csv and grades.xml. \n";
            }
            catch (Exception ex)
            {
                LBLinfo.ForeColor = Color.Red;
                LBLinfo.Text = "An error occurred: " + ex.Message + "\n";
            }
        }

        // Method to generate a random grade
        private string GenerateRandomGrade(Random random)
        {
            string[] grades = { "A", "B", "C", "D", "E", "F" };
            int randomIndex = random.Next(grades.Length);
            return grades[randomIndex];
        }

        // Method to get a list of IDs for a specific type
        private List<int> GetListIds<T>(string sql, Func<T, int> idSelector)
        {
            List<int> ids = new List<int>();
            List<T> objs = Data.GetData<T>(sql);

            foreach (T objItem in objs)
            {
                int id = idSelector(objItem);
                ids.Add(id);
            }

            return ids;
        }
    }


    // Enums - enumerations - means specific list
    // In C# enums are a special type of class. Its values represent a group of constant fields(variables)
    enum ListType
    {
        Detail,
        Module,
        Both
    }
}

