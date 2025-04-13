// using System;

// class InvalidInputException : Exception
// {
//     public InvalidInputException(string message) : base(message) { }
// }

// class Program
// {
//     static void Main()
//     {
//         try
//         {
//             Console.Write("Enter a number: ");
//             int number = int.Parse(Console.ReadLine());

//             if (number < 0)
//             {
//                 throw new InvalidInputException("Negative numbers are not allowed.");
//             }

//             Console.WriteLine($"You entered: {number}");
//         }
//         catch (InvalidInputException ex)
//         {
//             Console.WriteLine($"Error: {ex.Message}");
//         }
//         catch (FormatException)
//         {
//             Console.WriteLine("Error: Invalid input. Please enter a valid number.");
//         }
//     }
// }
