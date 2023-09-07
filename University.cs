using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
     class University
    {
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }

        public University()
        {
            Students = new List<Student>();
            Teachers = new List<Teacher>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }

        public void GetStudentsList()
        {

        }
    }
}
