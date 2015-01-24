//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.

using System;

class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        Console.Write("Write first number:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Write second number:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Write third number:");
        double c = double.Parse(Console.ReadLine());

        if(a >= b && a >= c)
        {
            if (b >= c)
            {
                Console.WriteLine("{0} {1} {2}", a, b, c);
            }
            else
                Console.WriteLine("{0} {1} {2}", a, c, b);
        }
        if(b >= c)
        {
            if ( a >= c)
            {
                Console.WriteLine("{0} {1} {2}", b, a, c);
            }
            else
                Console.WriteLine("{0} {1} {2}", b, c, a);
        }
        else
            if(b >=a)
            {
                Console.WriteLine("{0} {1} {2}", c, b, a);
            }
            else
            Console.WriteLine("{0} {1} {2}", c, a, b);

    }
}