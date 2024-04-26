using System;

namespace OcpExample
{
    public class EmployeeBad
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public EmployeeBad(string name, string position)
        {
            Name = name;
            Position = position;
        }

        public float CalculateSalary()
        {
            if (Position == "Developer")
            {
                return 5000;
            }
            else if (Position == "Manager")
            {
                return 10000; 
            }
            else
            {
                throw new InvalidOperationException("Invalid position");
            }
        }
    }
}
