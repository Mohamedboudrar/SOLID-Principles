using System;

namespace SRP
{
    public class Student
    {
        public string? Name { get; set; }
        public string? School { get; set; }
        public string? Department { get; set; }

        public Student(string name, string school, string department)
        {
            Name = name;
            School = school;
            Department = department;
        }
    }

    public class StudentInfoProvider
    {
        public string GetSchool()
        {
            return "UIR";
        }

        public string GetDepartment()
        {
            return ".NET";
        }
    }

    public class StudentRepository
    {
        public void Save(Student student)
        {
            // Save student to the database
            Console.WriteLine($"Saving {student.Name} who studies {student.Department} at {student.School} to the database...");
        }
    }
}
