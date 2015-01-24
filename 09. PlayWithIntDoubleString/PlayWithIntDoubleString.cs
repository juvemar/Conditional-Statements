/*Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.*/

using System;
    class PlayWithIntDoubleString
    {
        static void Main()
        {
            //Малко по-късно видях, че е даден пример как точно да се реши задачата, но мисля, че и този начин е хубав :)
            ushort inputType = 0;
            bool stringOrDouble;
            double inputDouble;
            Console.Write("Enter an integer, double or string: ");
            string input = Console.ReadLine();
            stringOrDouble = double.TryParse(input, out inputDouble);
            if (stringOrDouble)
            {
                inputType = 1;
            }
            
            switch(inputType)
            {
                case 0: Console.WriteLine(input + '*'); break;
                case 1: inputDouble++;
                    Console.WriteLine(inputDouble); break;
            }
        }
    }

