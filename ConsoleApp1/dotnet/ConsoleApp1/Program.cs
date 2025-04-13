// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// using System;

// class Program
// {
//     static void Main(string[] args) 
//     {
//         int[] arr = new int[] { 4, 5, 6, 7, 2, 9 };
//         Console.WriteLine("Enter number to search:");

//         int num;
//         if (!int.TryParse(Console.ReadLine(), out num))
//         {
//             Console.WriteLine("Invalid input. Please enter a valid integer.");
//             return;
//         }

//         bool found = false;

//         for (int i = 0; i < arr.Length; i++) 
//         {
//             if (num == arr[i])
//             {
//                 found = true;
//                 break;
//             }
//         }

//         if (found) 
//             Console.WriteLine("Element found");
//         else
//             Console.WriteLine("Element not found");
//     }
// }
// using System;

// class Program
// {
//     static void Main()
//     {
//         int[] numbers = new int[10];

//         // Taking 10 values as input from the user
//         Console.WriteLine("Enter 10 numbers:");
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write($"Enter number {i + 1}: ");
//             while (!int.TryParse(Console.ReadLine(), out numbers[i]))  // Validating input
//             {
//                 Console.WriteLine("Invalid input! Please enter a valid integer.");
//                 Console.Write($"Enter number {i + 1}: ");
//             }
//         }

//         // Sorting the array in ascending order
//         Array.Sort(numbers);

//         // Printing the sorted array
//         Console.WriteLine("\nNumbers in ascending order:");
//         foreach (int num in numbers)
//         {
//             Console.Write(num + " ");
//         }
//         Console.WriteLine(); // New line for better formatting
//     }
// }

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Hello, World!");
//     }
// }
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
    }
}
