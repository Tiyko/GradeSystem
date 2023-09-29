using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeSystem
{
    public class Student : Person
    {
        // Properties
        public int StudentID { get; set; }


        // Constructors
        public Student() { }

        public Student(int id, string fName, string lName)
        {
            StudentID = id;
            FName = fName;
            LName = lName;
        }

        public Student(string fName, string lName)
        {
            FName = fName;
            LName = lName;
        }
    }


    public sealed class StudentMap : ClassMap<Student>
    {
        // Constructors
        public StudentMap()
        {
            Map(m => m.FName).Name("FName"); // Map the student FName property to the FName header
            Map(m => m.LName).Name("LName"); // in the csv/xml file and the database

        }
    }

    public sealed class StudentXmlMap : ClassMap<Student>
    {
        // Constructors
        public StudentXmlMap()
        {
            Map(m => m.FName); // Map the student FName property to the FName header
            Map(m => m.LName); // in the csv/xml file and the database

        }
    }
}
