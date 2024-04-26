using System;

namespace OcpExample
{
    public interface ISalaryCalculator
    {
        float CalculateSalary();
    }

    public class DeveloperSalaryCalculator : ISalaryCalculator
    {
        public float CalculateSalary()
        {
            return 5000; 
        }
    }

    public class ManagerSalaryCalculator : ISalaryCalculator
    {
        public float CalculateSalary()
        {
            return 10000; 
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        private readonly ISalaryCalculator _salaryCalculator;

        public Employee(string name, string position, ISalaryCalculator salaryCalculator)
        {
            Name = name;
            Position = position;
            _salaryCalculator = salaryCalculator;
        }

        public float CalculateSalary()
        {
            return _salaryCalculator.CalculateSalary();
        }
    }

    
}
