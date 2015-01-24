//Write an if-statement that takes two double variables a and b and
//exchanges their values if the first one is greater than the second one.
//As a result print the values a and b, separated by a space.

using System;
class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Write your first double variable: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Write your second double variable:");
        double b = double.Parse(Console.ReadLine());
        double help=0;
        if(a>b)
        {
            help = a;
            a = b;
            b = help;
        }
        Console.WriteLine("{0} {1}", a, b);
    }
}