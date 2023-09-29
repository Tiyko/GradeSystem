using System;
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
        public string Stat = "TEACHER";


        // Constructor
        public FormDetailsMain()
        {
            InitializeComponent(); // function that initializes the designer class with the content of the form.
        }


        // Events
        private void FormDetailsMain_Load(object sender, EventArgs e)
        {
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

        private void RBstatus_CheckedChanged(object sender, EventArgs e)
        {
            if (RBteacher.Checked)
            {
                this.Text = "Teacher Details";
                LBLperson.Text = "Select Teacher";
                Stat = "TEACHER";
                BTNadd.Text = "NEW TEACHER";
                BTNaddMod.Text = "NEW MODULE";
                ShowStudentComponents(false);

                TXTBfirstName.Clear();
                TXTBlastName.Clear();
            }
            else
            {
                this.Text = "Student Details";
                LBLperson.Text = "Select Student";
                Stat = "STUDENT";
                BTNadd.Text = "NEW STUDENT";
                BTNaddMod.Text = "NEW GRADE";
                ShowStudentComponents(true);

                TXTBfirstName.Clear();
                TXTBlastName.Clear();
            }

            EnableAddButton(true);
            SetTextBoxReadOnly(true);
            EnableUpdateDeleteButtons(false, ListType.Both);
            LoadPersonDetails(Stat);

        }

        private void RBxml_CheckedChanged(object sender, EventArgs e)
        {
            TXTBfile.Clear();
        }

        private void RBcsv_CheckedChanged(object sender, EventArgs e)
        {
            TXTBfile.Clear();
        }



        private void CLBdetails_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox listBox = (CheckedListBox)sender;

            // Programatically uncheck the previously checked checkbox when the user 
            // checks another one. This means there will always be a maximum of
            // one item selected in the CheckListBox

            if (e.NewValue == CheckState.Checked)
            {
                for (int i = 0; i < listBox.Items.Count; i++)
                {
                    listBox.SetItemChecked(i, false);
                }
                EnableUpdateDeleteButtons(true);
            }
            else
            {
                EnableUpdateDeleteButtons(false);
            }
        }

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

        private void CLBmoduleDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void CLBmodules_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

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

        private void BTNupdateMod_Click(object sender, EventArgs e)
        {

        }

        private void BTNdeleteMod_Click(object sender, EventArgs e)
        {

        }

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
                else
                {

                }
            }
            LBLinfo.Text += res + "\n";

        }

        private void BTNclose_Click(object sender, EventArgs e)
        {
            DialogResult dlgRes = new DialogResult();
            dlgRes = MessageBox.Show("Are you sure you want to exit?", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dlgRes == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void BTNaddMod_Click(object sender, EventArgs e)
        {

        }


        private void TXTB_TextChanged(object sender, EventArgs e)
        {
            if ((TXTBfirstName.TextLength > 0 && TXTBlastName.TextLength > 0 &&
                BTNadd.Text == "SAVE " + Stat) ||
                BTNadd.Text == "NEW " + Stat)
            {
                EnableAddButton(true);
            }
            else
            {
                EnableAddButton(false);
            }
        }

        private void TXTBfile_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTBmodule_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTBgrade_TextChanged(object sender, EventArgs e)
        {

        }


        private void LBLfile_Click(object sender, EventArgs e)
        {

        }

        private void LBLmodName_Click(object sender, EventArgs e)
        {

        }

        private void LBLinfo_Click(object sender, EventArgs e)
        {

        }

        private void LBLperson_Click(object sender, EventArgs e)
        {

        }
        private void LBLgradeName_Click(object sender, EventArgs e)
        {

        }

        private void GBBulk_Enter(object sender, EventArgs e)
        {

        }
        private void PANELinfo_Paint(object sender, PaintEventArgs e)
        {

        }

        // Helper Methods
        public void LoadPersonDetails(string personType) // function to query the database and select a table depending on necessity
        {
            string sql = "select * from " + personType; // query the database and store the details in a variable
            Utils.LoadListBox(CLBdetails, sql, Stat); // populates the form CheckListBox with the details from the database
        }

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
            TXTBlastName.Text = lName; // to the form's textboxes, in the curent case
                                          // a student or a teacher's first and last name

        }

        private void LoadSelectedStudentGrade()
        {
            string id = Utils.GetSelectedID(CLBdetails);
            string sql = "Select m.ModName, g.TheGrade " +
                            "From Module m " +
                            "Join Grade g On g.ModID = m.ModID " +
                            "Where g.StudentID = '" + id + "'";

            // Clear the CLBModule items
            CLBmodules.Items.Clear();
            var moduleInfo = Data.GetData<Module>(sql);
            var gradeInfo = Data.GetData<Grade>(sql);
            // Load data into CLBModule
            Utils.LoadModListBox(CLBmodules, moduleInfo, gradeInfo);
        }

        private void SetAddButtonStateNew()
        {
            string buttonState = BTNadd.Text;
            

            if (buttonState == "SAVE " + Stat)
            {
                BTNadd.Text = "NEW " + Stat;

                SetTextBoxReadOnly(true);

                TXTBfirstName.Text = ""; // clearing fields using an empty string
                TXTBlastName.Clear(); // clearing fields using Clear() function
            }

        }


        private void SetAddButtonStateSave()
        {
            string buttonState = BTNadd.Text;
            if (buttonState == "NEW " + Stat)
            {
                Utils.UncheckListBoxItems(CLBdetails);
                LoadSelectedDetails();
                LoadModules();
                SetTextBoxReadOnly(false);

                BTNadd.Text = "SAVE " + Stat;
                BTNadd.Enabled = false; 
            }
        }


        private int AddTeacher()
        {
            string sql = "insert into " + Stat + "(fName, lName) Values('" + TXTBfirstName.Text + "', '" + TXTBlastName.Text + "')";

            int numRowsAffected = Data.ExecuteSqlNonQuery(sql);

            return numRowsAffected;

        }

        private int AddStudent() 
        {
            string storedProcedure = "SP_InsertStudent";
            string fName = TXTBfirstName.Text;
            string lName = TXTBlastName.Text;

            Dictionary<string, object> spParams = new Dictionary<string, object> 
            {
                { "@FirstName", fName },
                { "@LastName", lName }
            };

            int numRowsAffected = Data.ExecuteSqlNonQuery(storedProcedure, spParams, CommandType.StoredProcedure);
            return numRowsAffected;

        }

        private void EnableUpdateDeleteButtons(bool state, ListType listType = ListType.Detail)
        {
            if (listType == ListType.Detail)
            {
                BTNupdate.Enabled = state;
                BTNdelete.Enabled = state;
            }
            else if (listType == ListType.Module)
            {
                BTNupdateMod.Enabled = state;   
                BTNdeleteMod.Enabled = state;
            }
            else if (listType == ListType.Both)
            {
                BTNupdate.Enabled = state;
                BTNdelete.Enabled = state;
                BTNupdateMod.Enabled = state;
                BTNdeleteMod.Enabled = state;
            }

        }

        private void SetTextBoxReadOnly(bool state)
        {

            TXTBfirstName.ReadOnly = state;
            TXTBlastName.ReadOnly = state;
        }

        private void EnableAddButton(bool state) 
        {
            BTNadd.Enabled = state;
            BTNaddMod.Enabled = state;
        }

        private void ShowStudentComponents(bool state)
        {
            LBLgradeName.Visible = state;
            TXTBgrade.Visible = state;
            GBBulk.Visible = state;
        }

        private void LoadModules() 
        {
            string id = "0";
            id = Utils.GetSelectedID(CLBdetails);
            string sql = "select * from Module where TeacherID = '" + id + "';";

            Utils.LoadListBox(CLBmodules, sql, Stat);
        }

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
                mods.Add(new Module { 
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

        //private static Random random = new Random();
        private static string GenerateRandomGrade(Random random)
        {
            // Define an array of possible grades
            string[] grades = { "A", "B", "C", "D", "E", "F" };

            // Generate a random index to select a grade from the array
            int randomIndex = random.Next(grades.Length);

            // Return the randomly selected grade
            return grades[randomIndex];
        }

        public void GenerateGradeFiles()
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

















        // Enums - enumerations - means specific list
        // In C# enums are a special type of class. Its values represent a group of constant fields(variables)
        enum ListType
        {
            Detail,
            Module,
            Both
        }
    }
}
