using System;
public class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public decimal Bonus { get; set; }

    public virtual decimal CalculatePay()
    {
        return Salary + Bonus;
    }
}

public class PermanentEmployee : Employee
{
}

public class ContractualEmployee : Employee
{
    public ContractualEmployee(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
    }

    public override decimal CalculatePay()
    {
        return Salary;
    }
}


