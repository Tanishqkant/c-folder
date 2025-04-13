using System;

// Base class
class Vehicle
{
    public string Brand { get; set; }
    public int Year { get; set; }

    public Vehicle(string brand, int year)
    {
        Brand = brand;
        Year = year;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Year: {Year}");
    }
}

// Derived class from Vehicle
class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public Car(string brand, int year, int numberOfDoors)
        : base(brand, year)
    {
        NumberOfDoors = numberOfDoors;
    }

    public void ShowCarDetails()
    {
        DisplayInfo();
        Console.WriteLine($"Number of Doors: {NumberOfDoors}");
    }
}

// Derived class from Car
class ElectricCar : Car
{
    public int BatteryCapacity { get; set; }

    public ElectricCar(string brand, int year, int numberOfDoors, int batteryCapacity)
        : base(brand, year, numberOfDoors)
    {
        BatteryCapacity = batteryCapacity;
    }

    public void ShowElectricCarDetails()
    {
        ShowCarDetails();
        Console.WriteLine($"Battery Capacity: {BatteryCapacity} kWh");
    }
}

// Main entry point
class Program
{
    static void Main()  // ✅ Make sure this method exists
    {
        ElectricCar myElectricCar = new ElectricCar("Tesla", 2023, 4, 75);
        myElectricCar.ShowElectricCarDetails();
    }
}

