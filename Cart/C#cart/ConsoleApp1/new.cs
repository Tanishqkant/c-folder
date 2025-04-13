using System;

class Product
{
    // Data Members
    public string ProductName { get; set; }
    public double ProductPrice { get; set; }
    public string ModelNo { get; set; }
    public int YearOfManufacture { get; set; }
    public int QuantityAvailable { get; set; }

    // Constructor
    public Product(string name, double price, string model, int year, int quantity)
    {
        ProductName = name;
        ProductPrice = price;
        ModelNo = model;
        YearOfManufacture = year;
        QuantityAvailable = quantity;
    }

    // Method to add items
    public void AddItems(int quantity)
    {
        QuantityAvailable += quantity;
        Console.WriteLine($"{quantity} items added. New quantity: {QuantityAvailable}");
    }

    // Method to remove items
    public void RemoveItems(int quantity)
    {
        if (quantity > QuantityAvailable)
        {
            Console.WriteLine("Insufficient stock!");
        }
        else
        {
            QuantityAvailable -= quantity;
            Console.WriteLine($"{quantity} items removed. Remaining quantity: {QuantityAvailable}");
        }
    }

    // Method to display total cost of available products
    public void DisplayTotalCost()
    {
        double totalCost = QuantityAvailable * ProductPrice;
        Console.WriteLine($"Total cost of available {ProductName}: ${totalCost}");
    }
}

class Program
{
    static void Main()
    {
        // Creating Product object
        Product product1 = new Product("Laptop", 800.50, "L123", 2023, 10);
        
        // Display initial total cost
        product1.DisplayTotalCost();
        
        // Add items
        product1.AddItems(5);
        
        // Remove items
        product1.RemoveItems(3);
        
        // Display total cost again
        product1.DisplayTotalCost();
    }
}