/* 
Var Declaration in C# 
1 Using int, string, bool types.
*/
using System;
{
    class Program 
    {
        static void Main(string[] args)
        {
            // Declaring variables of different data types
            int age = 19; // Integer
            string name = "Vishal"; // String
            bool isStudent = true; // Boolean

            // Outputting the values of the variables to the console
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Is Student: " + isStudent);

            // Changing the value of the age variable
            age = 21; // Updated age
            Console.WriteLine("Updated Age: " + age);

            // Example of arithmetic operation
            int yearsUntilGraduation = 4; // Assuming 4 years until graduation
            int graduationYear = age + yearsUntilGraduation;
            Console.WriteLine("Expected Graduation Year: " + graduationYear);
        }
    }
}
-----------------------------------------
/*
2 
Var Declaration with Float, Double, Char, Decimal types.
*/
using System;

class Program
{
    static void Main()
    {
        // Float declaration
        float temperature = 36.6f; // Temperature in Celsius
        
        // Double declaration
        double distance = 149.6e6; // Distance from Earth to the Sun in kilometers

        // Char declaration
        char initial = 'C'; // First letter of a name
        
        // Decimal declaration
        decimal accountBalance = 12345.67m; // Bank account balance

        // Output the values
        Console.WriteLine("Temperature: " + temperature + " °C"); // Output: Temperature: 36.6 °C
        Console.WriteLine("Distance to Sun: " + distance + " km"); // Output: Distance to Sun: 149600000 km
        Console.WriteLine("Initial: " + initial); // Output: Initial: C
        Console.WriteLine("Account Balance: $" + accountBalance); // Output: Account Balance: $12345.67
    }
}
-----------------------------------------
/*
3 
Nullable Types and Enums
*/
using System;
class Program
{
    // Enumeration for days of the week
    enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }

    static void Main()
    {
        // Nullable integer
        int? nullableAge = null;

        // Check if the variable has a value
        if (nullableAge.HasValue)
        {
            Console.WriteLine("Nullable Age: " + nullableAge.Value);
        }
        else
        {
            Console.WriteLine("Age is not set.");
        }

        // Assigning a value to the nullable variable
        nullableAge = 21;
        Console.WriteLine("Updated Nullable Age: " + nullableAge.Value);

        // Using Enum
        Days today = Days.Wednesday;
        Console.WriteLine("Today is: " + today);
    }
}
—----------------------------------------
