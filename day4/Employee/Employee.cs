using System;
namespace MyEmployee;

public class Employee
{
    public string name;
    public int age;
    private int _employeeNumber;

    public int employeeNumber
    {
        get {return _employeeNumber ;}
        set {_employeeNumber = value ;}
    }

    public Employee(string name, int age, int employeeNumber)
    {
        this.name = name;
        this.age = age;
        _employeeNumber = employeeNumber;
    }
    public virtual void GetSalary(int salary)
    {
        Console.WriteLine($"Salary for {name}");
    }
}

public class FullTime : Employee, ITitle
{
    public FullTime(string name, int age, int employeeNumber) : base(name, age,employeeNumber)
    {

    }
    
    public override void GetSalary(int salary)
    {
        Console.WriteLine($"Salary for {name}");
        Console.WriteLine($"Salary Full Time is : {salary}");
    }

    public void GetTitle(string title)
    {
        Console.WriteLine($"{name} is a {title}");
    }
}

public class PartTime : Employee , IContract
{
    public PartTime(string name, int age, int employeeNumber) : base(name, age, employeeNumber)
    {

    }

    public void GetContract(int contract)
    {
        Console.WriteLine($"{name} contract is {contract} years");
    }

    public override void GetSalary(int salary)
    {
        Console.WriteLine($"Salary for {name}");
        Console.WriteLine($"Salary Per Hour is : {salary}");
    }
}
