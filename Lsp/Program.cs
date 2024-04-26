using System;

class Program
{
    static void Main(string[] args)
    {
        PermanentEmployeeBad permEmp = new PermanentEmployeeBad();
        permEmp.Name = "Mohamed";
        permEmp.Salary = 50000;
        permEmp.Bonus = 10000;

        ContractualEmployeeBad contractEmp = new ContractualEmployeeBad("Ali", 40000);

        Console.WriteLine("Permanent Employee Pay: " + permEmp.CalculatePay());
        Console.WriteLine("Contractual Employee Pay: " + contractEmp.CalculatePay());
        Console.ReadLine();
    }
}
