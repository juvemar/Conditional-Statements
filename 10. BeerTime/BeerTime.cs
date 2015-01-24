/*A beer time is after 1:00 PM and before 3:00 AM.
Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12],
a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time according to the definition above
or invalid time if the time cannot be parsed. Note: You may need to learn how to parse dates and times.*/

using System;

class BeerTime
{
    static void Main()
    {
        bool correctTime;
        DateTime time;

        Console.Write("Enter a time in format /hh:mm tt/: ");
        string productDate = Console.ReadLine();
        DateTime moreThan = DateTime.Parse("1:00 PM");
        DateTime lessThan = DateTime.Parse("3:00 AM");
        correctTime = DateTime.TryParse(productDate, out time);
        if (correctTime)
        {
            if (time >= moreThan || time < lessThan)
            {
                Console.WriteLine("beer time :)");
            }
            else
                Console.WriteLine("non-beer time :(");
        }
        else
            Console.WriteLine("invalid time");
    }
}
