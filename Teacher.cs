using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    class Teacher : Person
    {
        public string Department { get; set; }
        public string Position { get; set; }
        public Teacher(string lastname, string firstName, string middleName, string gender, string passportdata, string address, string department, string position)
                   : base(lastname, firstName, middleName, gender, passportdata, address)
        {
            Department = department;
            Position = position;
        }
    }
}
