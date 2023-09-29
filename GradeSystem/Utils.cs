using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeSystem
{
    internal class Utils
    {
        public string Text { get; set; }
        public string Value { get; set; }

        public static void LoadListBox(Control ctrl, string sql, string status)
        {

            CheckedListBox listBox = (CheckedListBox)ctrl;

            listBox.DisplayMember = "Text";
            listBox.ValueMember = "Value";
            listBox.Items.Clear();

            if (status == "TEACHER")
            {
                if (ctrl.Name == "CLBDetails")
                {
                    var teacherInfo = Data.GetData<Teacher>(sql);

                    foreach (var info in teacherInfo)
                    {
                        listBox.Items.Add(new Utils
                        {
                            Text = info.FName + " " + info.LName,
                            Value = info.TeacherID.ToString()
                        });
                    }
                }

                else if (ctrl.Name == "CLBModules")
                {
                    var moduleInfo = Data.GetData<Module>(sql);

                    foreach (var info in moduleInfo)
                    {
                        listBox.Items.Add(new Utils
                        {
                            Text = info.ModName,
                            Value = info.ModID.ToString()
                        });
                    }
                }

            }
            else if (status == "STUDENT")
            {
                if (ctrl.Name == "CLBDetails")
                {
                    var studentInfo = Data.GetData<Student>(sql);

                    foreach (var info in studentInfo)
                    {
                        listBox.Items.Add(new Utils
                        {
                            Text = info.FName + " " + info.LName,
                            Value = info.StudentID.ToString()
                        });
                    }
                }

                
            }
                 
        
        }

        public static void LoadModListBox(Control ctrl, List<Module> modInfo, List<Grade> gradeInfo)
        {
            CheckedListBox listBox = (CheckedListBox)ctrl;
            listBox.DisplayMember = "Text";
            listBox.ValueMember = "Value";
            listBox.Items.Clear();

            for (int i = 0; i < modInfo.Count; i++)
            {
                string modName = modInfo[i].ModName;
                string grade = gradeInfo[i].TheGrade;

                listBox.Items.Add(new Utils
                {
                    Text = $"{modName} (Grade: {grade})",
                    Value = modInfo[i].ModID.ToString()
                });
            }
        }

        public static string GetSelectedID(Control ctrl)
        {
            CheckedListBox listBox = (CheckedListBox)ctrl;

            string id = "";
            foreach (var item in listBox.CheckedItems)
            {
                var selectItem = (Utils)item;
                id = selectItem.Value;
            }

            return id;
        }

        public static void UncheckListBoxItems(Control ctrl)
        {
            CheckedListBox listBox = (CheckedListBox)ctrl;

            for (int i = 0; i < listBox.Items.Count; i++)
            {
                listBox.SetItemChecked(i, false);
            }
        }


    }
}
