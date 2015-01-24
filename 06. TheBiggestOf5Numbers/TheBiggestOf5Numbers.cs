//Write a program that finds the biggest of five numbers by using only five if statements.

using System;

class TheBiggestOf5Numbers
{
    static void Main()
    {
        Console.Write("Write first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Write second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Write third number: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Write fourth number: ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("Write fifth number: ");
        double e = double.Parse(Console.ReadLine());
        double biggest = 0;
        if (a > b && a > c && a > d && a > e)
        {
            biggest = a;
        }
        else
            if (b > c && b > d && b > e)
            {
                biggest = b;
            }
            else
            {
                if (c > d && c > e)
                {
                    biggest = c;
                }
                else
                    if (d > e)
                    {
                        biggest = d;
                    }
                    else
                        if (e > d)
                        {
                            biggest = e;
                        }
            }
        Console.WriteLine("{0} is the biggest!", biggest);
    }
}