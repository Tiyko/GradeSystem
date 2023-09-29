using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        private void FormTeacherList_Load(object sender, EventArgs e)
        {
            Data.GetRootDir();
            string res = "";

            res = Data.InsertObjectsFromCsv<Teacher>(Data.RootDir + "\\Teacher\\InitTeachers.csv");
            LBLInfo.Text += res + "\n";

            res = Data.InsertObjectsFromCsv<Student>(Data.RootDir + "\\Student\\InitStudents.csv");
            LBLInfo.Text += res + "\n";

            // Populate the CheckedListBox with a list of teachers from the database
            LoadPersonDetails(Stat);
            AssignModules();
            GenerateGradeFiles();

        }

        private void RBStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (RBTeacher.Checked)
            {
                this.Text = "Teacher Details";
                LBLPerson.Text = "Select Teacher";
                Stat = "TEACHER";
                BtnAdd.Text = "NEW TEACHER";
                BTNAddMod.Text = "NEW MODULE";
                ShowStudentComponents(false);

                textBoxFirstName.Clear();
                textBoxLastName.Clear();
            }
            else
            {
                this.Text = "Student Details";
                LBLPerson.Text = "Select Student";
                Stat = "STUDENT";
                BtnAdd.Text = "NEW STUDENT";
                BTNAddMod.Text = "NEW GRADE";
                ShowStudentComponents(true);

                textBoxFirstName.Clear();
                textBoxLastName.Clear();
            }

            EnableAddButton(true);
            SetTextBoxReadOnly(true);
            EnableUpdateDeleteButtons(false, ListType.Both);
            LoadPersonDetails(Stat);

        }

        private void CLBDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSelectedDetails();
            LoadModules();
            SetAddButtonStateNew();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult dlgRes = new DialogResult();
            dlgRes = MessageBox.Show("Are you sure you want to exit?", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dlgRes == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void CLBDetails_ItemCheck(object sender, ItemCheckEventArgs e)
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            string buttonState = BtnAdd.Text;
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

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if ((textBoxFirstName.TextLength > 0 && textBoxLastName.TextLength > 0 &&
                BtnAdd.Text == "SAVE " + Stat) ||
                BtnAdd.Text == "NEW " + Stat)
            {
                EnableAddButton(true);
            }
            else
            {
                EnableAddButton(false);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BTNAddMod_Click(object sender, EventArgs e)
        {

        }

        private void CLBModules_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

        private void BTNUpdateMod_Click(object sender, EventArgs e)
        {

        }

        private void BTNDeleteMod_Click(object sender, EventArgs e)
        {

        }

        private void BTNFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                string filePath = Data.GetRootDir() + "\\Grade\\";
                if (RBCSV.Checked)
                {
                    dlg.Title = "Select CSV File!";
                    dlg.Filter = "CSV Files (*.csv)|*.csv";
                }
                else if (RBXML.Checked)
                {

                    dlg.Title = "Select XML File!";
                    dlg.Filter = "XML Files (*.xml)|*.xml";


                }

                dlg.InitialDirectory = filePath;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    var file = dlg.FileName.Replace(filePath, "");
                    textBoxFile.Text = file;
                    BTNImport.Enabled = true;
                }
                
            }
        }

        private void textBoxFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNImport_Click(object sender, EventArgs e)
        {
            string res = "";
            string filePath = Data.GetRootDir() + "\\Grade\\";
            if (textBoxFile.TextLength > 0) 
            {
                filePath += textBoxFile.Text;
                if (RBCSV.Checked)
                {
                   res = Data.InsertObjectsFromCsv<Grade>(filePath);
                }
                else if (RBCSV.Checked)
                {
                   res = Data.InsertObjectsFromXml<Grade>(filePath);
                }
            }
            LBLInfo.Text += res;
        }

        private void RBXML_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxModule_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxGrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void LBLModName_Click(object sender, EventArgs e)
        {

        }

        private void LBLInfo_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxBulk_Enter(object sender, EventArgs e)
        {

        }

        private void LBLPerson_Click(object sender, EventArgs e)
        {

        }

        // Helper Methods
        public void LoadPersonDetails(string personType) // function to query the database and select a table depending on necessity
        {
            string sql = "select * from " + personType; // query the database and store the details in a variable
            Utils.LoadListBox(CLBDetails, sql, Stat); // populates the form CheckListBox with the details from the database
        }

        private void LoadSelectedDetails()
        {
            // variables to store the details retrieved from the database
            string id = "0";
            string fName = "";
            string lName = "";
            string sql = "";

            id = Utils.GetSelectedID(CLBDetails); // load and store the selected id from the User (CheckListBox)
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

            textBoxFirstName.Text = fName; // display the retrevied and stored information
            textBoxLastName.Text = lName; // to the form's textboxes, in the curent case
                                          // a student or a teacher's first and last name

        }

        private void LoadSelectedStudentGrade() 
        {
            string id = Utils.GetSelectedID(CLBDetails);
            string sql = "select m.ModName, TheGrade from Module join Grade on g.ModID = m.ModID where g.StudentID = '" + id + "'";

            CLBModules.Items.Clear();

            var modInfo = Data.GetData<Module>(sql);
            var gradeInfo = Data.GetData<Grade>(sql);

            Utils.LoadListBox
        }

        private void SetAddButtonStateNew()
        {
            string buttonState = BtnAdd.Text;
            

            if (buttonState == "SAVE " + Stat)
            {
                BtnAdd.Text = "NEW " + Stat;

                SetTextBoxReadOnly(true);

                textBoxFirstName.Text = ""; // clearing fields using an empty string
                textBoxLastName.Clear(); // clearing fields using Clear() function
            }

        }


        private void SetAddButtonStateSave()
        {
            string buttonState = BtnAdd.Text;
            if (buttonState == "NEW " + Stat)
            {
                Utils.UncheckListBoxItems(CLBDetails);
                LoadSelectedDetails();
                LoadModules();
                SetTextBoxReadOnly(false);

                BtnAdd.Text = "SAVE " + Stat;
                BtnAdd.Enabled = false; 
            }
        }


        private int AddTeacher()
        {
            string sql = "insert into " + Stat + "(fName, lName) Values('" + textBoxFirstName.Text + "', '" + textBoxLastName.Text + "')";

            int numRowsAffected = Data.ExecuteSqlNonQuery(sql);

            return numRowsAffected;

        }

        private int AddStudent() 
        {
            string storedProcedure = "SP_InsertStudent";
            string fName = textBoxFirstName.Text;
            string lName = textBoxLastName.Text;

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
                BtnUpdate.Enabled = state;
                BtnDelete.Enabled = state;
            }
            else if (listType == ListType.Module)
            {
                BTNUpdateMod.Enabled = state;   
                BTNDeleteMod.Enabled = state;
            }
            else if (listType == ListType.Both)
            {
                BtnUpdate.Enabled = state;
                BtnDelete.Enabled = state;
                BTNUpdateMod.Enabled = state;
                BTNDeleteMod.Enabled = state;
            }

        }

        private void SetTextBoxReadOnly(bool state)
        {

            textBoxFirstName.ReadOnly = state;
            textBoxLastName.ReadOnly = state;
        }

        private void EnableAddButton(bool state) 
        {
            BtnAdd.Enabled = state;
            BTNAddMod.Enabled = state;
        }

        private void ShowStudentComponents(bool state)
        {
            LBLGradeName.Visible = state;
            textBoxGrade.Visible = state;
            groupBoxBulk.Visible = state;
        }

        private void LoadModules() 
        {
            string id = "0";
            id = Utils.GetSelectedID(CLBDetails);
            string sql = "select * from Module where TeacherID = '" + id + "';";

            Utils.LoadListBox(CLBModules, sql, Stat);
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

            LBLInfo.Text += "modules.xml file created \n";
            res = Data.InsertObjectsFromXml<Module>(Data.GetRootDir() + "\\Module\\modules.xml");
            LBLInfo.Text += res;
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

                LBLInfo.ForeColor = Color.Green;
                LBLInfo.Text += "Grades generated and saved to grades.csv and grades.xml. \n";
                LBLInfo.ForeColor = Color.Blue;
            }
            catch (Exception ex)
            {
                LBLInfo.ForeColor = Color.Red;
                LBLInfo.Text += "An error occurred: " + ex.Message + "\n";
                LBLInfo.ForeColor = Color.Blue;
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
