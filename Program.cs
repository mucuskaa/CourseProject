namespace CourseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student("Smith", "John", "Doe", "Male", "123456789", "123 Main St", "IT-101", "John Smith Sr.", "Computer Science", "IT", true),
                 new Student("Johnson", "Jane", "Smith", "Female", "987654321", "456 Elm St", "B-201", "Mary Johnson", "Finance", "Business", false),
                 new Student("Williams", "Robert", "Lee", "Male", "456789123", "789 Oak St", "CS-202", "David Williams", "Computer Science", "IT", false),
                 new Student("Brown", "Lisa", "Johnson", "Female", "654321987", "321 Maple St", "ECO-101", "Jennifer Brown", "Economics", "Business", false),
                 new Student("Davis", "Michael", "Smith", "Male", "789123456", "654 Pine St", "ENG-301", "Laura Davis", "Engineering", "Engineering", false),
                     new Student("Artinez", "Sofia", "Garcia", "Female", "852369741", "987 Cedar St", "MATH-201", "Carlos Martinez", "Mathematics", "Science", false),
            };

            StudentsList stud = new StudentsList(students);
            stud.SortStudentsByFullName();
            foreach (var student in stud.Students)
            {
                Console.WriteLine($"Ім'я студента: {student.LastName} {student.FirstName}");
            }

        }
    }
}