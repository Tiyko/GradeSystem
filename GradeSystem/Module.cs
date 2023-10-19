using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeSystem
{
    public class Module
    {
        // Properties
        public int ModID { get; set; }
        public string ModName { get; set; }
        public int TeacherID { get; set; }

        // Constructors
        public Module() { }

        public Module(int modID, string modName, int teacherID)
        {
            ModID = modID;
            ModName = modName;
            TeacherID = teacherID;
        }

        public Module(string modName, int teacherID)
        {
            ModName = modName;
            TeacherID = teacherID;
        }

    }


    public sealed class ModuleMap : ClassMap<Module>
    {
        // Constructors
        public ModuleMap()
        {
            Map(m => m.ModName).Name("ModName");
            Map(m => m.TeacherID).Name("TeacherID");

        }
    }

    public sealed class ModuleXmlMap : ClassMap<Module>
    {
        // Constructors
        public ModuleXmlMap()
        {
            Map(m => m.ModName);
            Map(m => m.TeacherID);

        }
    }
}
