// using System;

// class Person
// {
//     public string Name { get; set; }
//     public int Age { get; set; }

//     public Person(string name, int age)
//     {
//         Name = name;
//         Age = age;
//     }
// }

// class Student : Person
// {
//     public int StudentID { get; set; }

//     public Student(string name, int age, int studentID) : base(name, age)
//     {
//         StudentID = studentID;
//     }

//     public void DisplayDetails()
//     {
//         Console.WriteLine($"Student Details:\nName: {Name}\nAge: {Age}\nStudent ID: {StudentID}");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Student student = new Student("Alice", 20, 1001);
//         student.DisplayDetails();
//     }
// }
