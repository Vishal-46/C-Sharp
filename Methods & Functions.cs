//Basics of Methods and function calling in a single simple Example:
/*using System;
class Program
{
    // Method to greet a user with a default country if none is specified
    public static void GreetUser(string name, string country = "USA")
    {
        Console.WriteLine($"Hello, {name} from {country}!");
    }

    // Method to add two integers and return the result
    public static int Add(int a, int b)
    {
        return a + b;
    }

    // Recursive method to calculate the factorial of a number
    public static int Factorial(int n)
    {
        if (n <= 1)
            return 1;
        else
            return n * Factorial(n - 1);
    }

    // Method demonstrating pass-by-reference to double a number
    public static void DoubleValue(ref int number)
    {
        number *= 2;
    }

    static void Main()
    {
        // 1. Using a method with a default parameter
        GreetUser("Alice");               // Uses default country
        GreetUser("Bob", "Canada");        // Overrides default country

        // 2. Using a method that returns a value
        int sum = Add(10, 20);
        Console.WriteLine("Sum: " + sum);  // Output the result of addition

        // 3. Calculating factorial using recursion
        int factorialOf5 = Factorial(5);
        Console.WriteLine("Factorial of 5: " + factorialOf5);

        // 4. Modifying a value using pass-by-reference
        int myNumber = 15;
        DoubleValue(ref myNumber);
        Console.WriteLine("Doubled Value: " + myNumber);
    }
}
