using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    internal class StudentsList
    {
        private int studentsCount;
        public List<Student> Students { get; set; }

        public StudentsList(List<Student> students)
        {
            Students = students;
            studentsCount = Students.Count;
        }
        public void AddStudent(Student student)
        {
            Students.Add(student);

        }

        public void SortStudentsByFaculty( )
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i < studentsCount; i++)
                {
                    if (string.Compare(Students[i - 1].Faculty, Students[i].Faculty) > 0)
                    {
                        Student temp = Students[i - 1];
                        Students[i - 1] = Students[i];
                        Students[i] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
        }

        public void SortStudentsByGroup()
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i < studentsCount; i++)
                {
                    if (string.Compare(Students[i - 1].Group, Students[i].Group) > 0)
                    {
                        Student temp = Students[i - 1];
                        Students[i - 1] = Students[i];
                        Students[i] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
        }

        public void SortStudentsByFullName()
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i < studentsCount; i++)
                {
                    string fullName1 = $"{Students[i - 1].LastName} {Students[i - 1].FirstName} {Students[i - 1].MiddleName}";
                    string fullName2 = $"{Students[i].LastName} {Students[i].FirstName} {Students[i].MiddleName}";

                    if (string.Compare(fullName1, fullName2) > 0)
                    {
                        Student temp = Students[i - 1];
                        Students[i - 1] = Students[i];
                        Students[i] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
        }

        public void SortStudentsByProfileDepartment()
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i < studentsCount; i++)
                {
                    if (string.Compare(Students[i - 1].ProfileDepartment, Students[i].ProfileDepartment) > 0)
                    {
                        Student temp = Students[i - 1];
                        Students[i - 1] = Students[i];
                        Students[i] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
        }
    }
}
