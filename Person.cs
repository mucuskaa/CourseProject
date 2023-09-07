using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    class Person
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Gender { get; set; }
        public string PassportData { get; set; }
        public string Address { get; set; }
        public Person(string lastname, string firtstName, string midleName, string gender, string passportdata, string adress)
        {
            LastName = lastname;
            FirstName = firtstName;
            MiddleName = midleName;
            Gender = gender;
            PassportData = passportdata;
            Address = adress;
        }
    }
}
