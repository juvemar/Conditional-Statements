//Write a program that finds the biggest of three numbers.

using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.Write("Write first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Write second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Write third number: ");
        double c = double.Parse(Console.ReadLine());

        if (a >= b && a >= c)
        {
            Console.WriteLine("{0} is the biggest", a);
        }
        else
            if (b > a && b >= c)
            {
                Console.WriteLine("{0} is the biggest", b);
            }
            else
                Console.WriteLine("{0} is the biggest", c);
    }
}