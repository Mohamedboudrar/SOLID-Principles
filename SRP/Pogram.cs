using System;
namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentInfoProvider infoProvider = new StudentInfoProvider();
            StudentRepository repository = new StudentRepository();

            // Test the RightUsage of SRP

            
            string School = infoProvider.GetSchool();
            string Department = infoProvider.GetDepartment();
            Student student = new Student("Mohamed Boudrar", School, Department);


            repository.Save(student);
            Console.ReadLine();
        }
    }
}
