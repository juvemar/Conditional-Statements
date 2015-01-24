//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

using System;
class MultiplicationSign
{
    static void Main()
    {
        Console.Write("Write \"a\": ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Write \"b\": ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Write \"c\": ");
        double c = double.Parse(Console.ReadLine());

        int minusesCounter = 0;

        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine('0');
            return;
        }
        else
        {
            if (a < 0)
            {
                minusesCounter++;
            }
            
            if(b < 0)
            {
                minusesCounter++;
            }
            if(c < 0)
            {
                minusesCounter++;
            }
        }
        if(minusesCounter == 1 || minusesCounter == 3)
        {
            Console.WriteLine('-');
        }
        else
            Console.WriteLine('+');
    }
}