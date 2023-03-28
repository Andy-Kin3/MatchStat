using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static int Age { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public string FullNameWithAge
        {
            get
            {
                return $"{FirstName} {LastName} ({Age} years old)";
            }
        }
    }
}
