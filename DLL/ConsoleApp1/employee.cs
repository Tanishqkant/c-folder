using System;

class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }

    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, Salary: {Salary:C}");
    }
}

class Manager : Employee
{
    public string Department { get; set; }

    public Manager(string name, double salary, string department) 
        : base(name, salary)
    {
        Department = department;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Department: {Department}");
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee("John Doe", 50000);
        emp.DisplayDetails();
        Console.WriteLine();

        Manager mgr = new Manager("Jane Smith", 80000, "IT");
        mgr.DisplayDetails();
    }
}
