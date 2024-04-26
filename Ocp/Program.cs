using OcpExample;
namespace OcpExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a developer with regular salary
            Employee developer = new Employee("Mohamed BOUDRAR", "Developer", new DeveloperSalaryCalculator());
            Console.WriteLine($"{developer.Name}'s salary: ${developer.CalculateSalary()}");

            // Create a manager with high salary
            Employee manager = new Employee("Said WAHID", "Manager", new ManagerSalaryCalculator());
            Console.WriteLine($"{manager.Name}'s salary: ${manager.CalculateSalary()}");

            Console.ReadLine();
        }
        
    }
}
