using System;

class SalaryCalculator
{
    // Square
    public int Salary(int a)
    {
        int baseSalary = a;
        return baseSalary;
    }

    // Rectangle
    public int Salary(int a, int bonus)
    {
        int Bonuses = a + bonus;
        return Bonuses;
    }

    // Circle (Fixed the incorrect formula)
    public int Salary(int a, int bonus, int overtime)
    {
        int salaries = a+ bonus + overtime;
        return salaries;
    }

   
}

class Program 
{
    static void Main()
    {
        SalaryCalculator x = new SalaryCalculator();
        
        Console.WriteLine("Area of square: " + x.Salary(30));
        Console.WriteLine("Area of rectangle: " + x.Salary(30, 50));
        Console.WriteLine("Area of triangle: " + x.Salary(33,89,70));
       
        
        // Prevent console from closing immediately
        Console.ReadLine();
    }
}