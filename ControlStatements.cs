/*
Conditional Statements 
  *if   elseif  else,
  *Switch Statements,
  *Ternary Conditional Operator.
*/

//1)  if  elseif  else
using System;
class Program
{
    static void Main()
    {
        int age = 20; // Define an integer variable named 'age' and assign it a value of 20.
        if (age >= 18) // Check if age is greater than or equal to 18
        {
            Console.WriteLine("You are an adult."); // If age is 18 or older, this message will display.
        }
        else if (age >= 13 && age < 18) // If not an adult, check if age is between 13 and 17.
        {
            Console.WriteLine("You are a teenager."); // Executes if age is in the teenage range.
        }
        else
        {
            Console.WriteLine("You are a child."); // Executes if age is below 13.
        }
    }
}


