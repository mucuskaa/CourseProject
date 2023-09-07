using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    class Student : Person
    {
        public string Group { get; set; }
        public string Parent { get; set; }
        public string ProfileDepartment { get; set; }
        public string Faculty { get; set; }
        public bool IsMonitor { get; set; }

        public Student(string lastname, string firtstName, string midleName, string gender, string passpotdata, string adress, string group, string parent, string profileDepartment, string faculty, bool isMonitor)
            : base(lastname,firtstName,midleName,gender, passpotdata, adress)
        {
            Group = group;
            Parent = parent;
            ProfileDepartment = profileDepartment;
            Faculty = faculty;
            IsMonitor = isMonitor;
        }
    }
}
