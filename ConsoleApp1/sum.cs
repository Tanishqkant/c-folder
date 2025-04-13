using System;

class Program
{
    static void Main(string[] args) 
    {
        int[] arr = new int[] { 4, 5, 6, 7, 2, 9 };
        Console.WriteLine("Enter number to search:");

        int num;
        if (!int.TryParse(Console.ReadLine(), out num))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return;
        }

        bool found = false;

        for (int i = 0; i < arr.Length; i++) 
        {
            if (num == arr[i])
            {
                found = true;
                break;
            }
        }

        if (found) 
            Console.WriteLine("Element found");
        else
            Console.WriteLine("Element not found");
    }
}
