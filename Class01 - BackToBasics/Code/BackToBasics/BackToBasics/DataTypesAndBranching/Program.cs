using System;

namespace DataTypesAndBranching
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 6;
            int negativeNumber = -9;
            float floatNumber = 4.3F;
            double doubleNumber = 5.7;

            char character = 'a';
            string sentence = "Hello from SEDC, year 2021!";

            bool boolValue = true;

            Console.WriteLine(number);
            Console.WriteLine(negativeNumber);
            Console.WriteLine(doubleNumber);
            Console.WriteLine(character);
            Console.WriteLine(sentence);
            Console.WriteLine(boolValue);
            Console.WriteLine("=========================");

            //Using Parse() method for parsing into int (Throws an error if parse fails)
            int parsedNumber = int.Parse("34");
            //int anotherParsedNumber = int.Parse("SEDC"); //can not be parsed into int

            double parsedDoubleNumber = double.Parse("56.7");

            Console.WriteLine(parsedNumber);
            Console.WriteLine(parsedDoubleNumber);

            Console.WriteLine(parsedNumber.GetType());
            Console.WriteLine(parsedNumber.GetType().Name);

            Console.WriteLine(parsedDoubleNumber.GetType());
            Console.WriteLine(parsedDoubleNumber.GetType().Name);

            //Using TryParse() method for parsing into int. Safe option, and we have more control over the code
            int parsedInteger;
            bool succesfullyParsed = int.TryParse("32", out parsedInteger);
            Console.WriteLine(succesfullyParsed);
            Console.WriteLine(parsedInteger);

            int secondParsedInteger;
            bool success = int.TryParse("Hello", out secondParsedInteger);
            Console.WriteLine(success);
            Console.WriteLine(secondParsedInteger);

            int parsedInput;
            Console.WriteLine("Please enter a number");
            string input = Console.ReadLine();

            bool isUserInputParsed = int.TryParse(input, out parsedInput);
            if (isUserInputParsed)
            {
                Console.WriteLine("Thank you! Have a nice day!");
                Console.WriteLine("You entered:");
                Console.WriteLine(parsedInput);
            }
            else
            {
                Console.WriteLine("Wrong input! Try again!");
            }

            Console.WriteLine("=========Conditional statements==============");

            int a = 3;
            int b = 7;

            if (a > b)
            {
                Console.WriteLine(" a is greater than b");
            }
            else if(b > a)
            {
                Console.WriteLine(" b is greater than a");
            }
            else
            {
                Console.WriteLine("The numbers are equal!");
            }

            int c = 10;

            if(a > b)
            {
                Console.WriteLine(" a is greater than b, here we stop!");
            }
            else if(c > a)
            {
                if(b > a)
                {
                    Console.WriteLine("a is the smallest number");
                }
            }
            else
            {

            }

            string color = "yellow";
            switch (color)
            {
                case "red":
                    Console.WriteLine("Red means you must stop!");
                    break;
                case "yellow":
                    Console.WriteLine("Yellow means prepare for passing!");
                        break;
                case "green":
                    Console.WriteLine("Green means pass!");
                    break;
                default:
                    Console.WriteLine("Invalid color value!");
                    break;

            }

            int day = 3;
            switch (day)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Working day!");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("It's weekend!");
                    break;
                default:
                    Console.WriteLine("Invalid week day!");
                    break;


            }

            Console.ReadLine();
        }
    }
}
