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
------------------------------------------------------------------------------------------------------------------------------------------
//2) Switch Statements
using System;
class Program
{
    static void Main()
    {
        int month = 4; // Assign month variable with the value 4.
        switch (month) // Start switch statement to evaluate 'month' variable.
        {
            case 1:
                Console.WriteLine("January");
                break; // Ends execution of this case
            case 2:
                Console.WriteLine("February");
                break;
            case 3:
                Console.WriteLine("March");
                break;
            case 4:
                Console.WriteLine("April");
                break;
            default:
                Console.WriteLine("Invalid month");
                break; // 'default' handles any value not matched by cases above.
        }
    }
}
--------------------------------------------------------------------------------------------------------------------------------------------
//3) Ternary Conditional Operator
using System;
class Program
{
    static void Main()
    {
        int score = 75; // Define integer 'score' with a value of 75,
        string result = (score >= 50) ? "Pass" : "Fail"; // Ternary operator to check if score >= 50, then assign "Pass" else "Fail"
        Console.WriteLine("Result: " + result); // Displays "Pass" if score >= 50; otherwise, "Fail"
    }
}

-------------------------------------------------------------------------------------------------------------------------------------------
