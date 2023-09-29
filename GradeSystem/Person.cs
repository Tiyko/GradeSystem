using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeSystem
{
    // ABSTRACT CLASS - can only be accessed through inheritance from other classes. 
    //                  In the current case the Student and the Teacher classes
    public abstract class Person
    {
        
        /*
         * PROPERTIES
         * - are a combination of methods and fields/variables
         * - they have 2 methods built in - "set" and "get"
         * - use camelCase to name fields and PascalCase for properties
         *   to make it clear that they are related.
         * - naming should make it obvious that they are related.
         */
        public string FName { get; set; }
        public string LName { get; set; }

    }


}
