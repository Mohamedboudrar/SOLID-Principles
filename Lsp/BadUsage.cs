using System;

public class EmployeeBad
{
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public decimal Bonus { get; set; }

    public decimal CalculatePay(EmployeeBad employeebad)
    {
        return Salary + Bonus;
    }
}

public class PermanentEmployeeBad : Employee
{
}

public class ContractualEmployeeBad : Employee
{
    public ContractualEmployeeBad(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
        Bonus = 0; // Not necessary for contractual employees
    }
}
