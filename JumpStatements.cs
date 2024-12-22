//Break Statement
using System;
class Program
{
    static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            if (i == 3)
            {
                Console.WriteLine("Breaking out of the loop when i is 3");
                break;  // Exit the loop
            }
            Console.WriteLine("i = " + i);
        }
    }
}
----------------------------------------------------------------------------------------------
