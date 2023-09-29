using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace GradeSystem
{
    public class Teacher : Person     // Inheritance from the Abstract class Person of common atributes
    {
        // Properties
        public int TeacherID { get; set; }

        // Constructors
        /*
         * POLYMORPHISM / OVERLOADED
         *  - many methods/constructors with the same name but with different parameter list
         *      to function differently.
         */
        public Teacher() { }

        public Teacher(int id, string fName, string lName)
        {
            TeacherID = id;
            FName = fName;
            LName = lName;
        }
        
        public Teacher(string fName, string lName)
        {
            FName = fName;
            LName = lName;
        }
    }


    public sealed class TeacherMap : ClassMap<Teacher> 
    {
        // Constructors
        public TeacherMap()
        {
            Map(m => m.FName).Name("FName"); // Map the teacher FName property to the FName header
            Map(m => m.LName).Name("LName"); // in the csv/xml file and the database

        }
    }

    public sealed class TeacherXmlMap : ClassMap<Teacher>
    {
        // Constructors
        public TeacherXmlMap()
        {
            Map(m => m.FName); // Map the teacher FName property to the FName header
            Map(m => m.LName); // in the csv/xml file and the database

        }
    }

}
