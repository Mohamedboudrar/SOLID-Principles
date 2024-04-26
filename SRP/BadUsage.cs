using System;

namespace SRP
{
    public class StudentBad
    {
        public string? Name { get; set; }
        public string? School { get; set; }
        public string? Department { get; set; }

        public StudentBad(string name, string school, string department)
        {
            Name = name;
            School = school;
            Department = department;
        }
    }

    

    public class StudentInfoProviderBad
    {
        public string GetSchool()
        {
            return "UIR";
        }

        public string GetDepartment()
        {
            return ".NET";
        }

        public void save(StudentBad student)
        {
            // Save student to the database
            Console.WriteLine($"Saving {student.Name} to the database...");
        }
    }
}
