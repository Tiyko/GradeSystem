using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GradeSystem
{
    public class Grade
    {
        // Properties
        public int GradeID { get; set; }
        public string TheGrade { get; set; }
        public int ModID { get; set;}
        public int StudentID { get; set; }

        // Constructors
        public Grade() { }

        public Grade(int gradeID, string theGrade, int modID, int studentID)
        {
            GradeID = gradeID;
            TheGrade = theGrade;
            ModID = modID;
            StudentID = studentID;
        }

        public Grade(string theGrade, int modID, int studentID)
        {
            TheGrade = theGrade;
            ModID = modID;
            StudentID = studentID;
        }

    }


    public sealed class GradeMap : ClassMap<Grade>
    {
        // Constructors
        public GradeMap()
        {
            Map(m => m.TheGrade).Name("TheGrade");
            Map(m => m.ModID).Name("ModID");
            Map(m => m.StudentID).Name("StudentID");

        }
    }

    public sealed class GradeXmlMap : ClassMap<Grade>
    {
        // Constructors
        public GradeXmlMap()
        {
            Map(m => m.TheGrade);
            Map(m => m.ModID);
            Map(m => m.StudentID);

        }
    }
}
