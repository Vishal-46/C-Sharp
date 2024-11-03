/*
Looping Statments
   *For Loop
   *While Loop
   *Do While Loop
*/

//For Loop
using System;
class Program
{
    static void Main()
    {
        // For loop to iterate from 0 to 4
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Iteration: " + i); // Print current iteration
        }
    }
}
------------------------------------------------------------------------------------

//While Loop
using System;
class Program
{
    static void Main()
    {
        int i = 0; // Initialize counter
        // While loop continues as long as i is less than 5
        while (i < 5)
        {
            Console.WriteLine("Iteration: " + i); // Print current iteration
            i++; // Increment counter
        }
    }
}
------------------------------------------------------------------------------------

//Do While Loop
using System;
class Program
{
    static void Main()
    {
        int i = 0; // Initialize counter
        do
        {
            Console.WriteLine("Iteration: " + i); // Print current iteration
            i++; // Increment counter
        } while (i < 5); // Check condition after execution
    }
}
-------------------------------------------------------------------------------------