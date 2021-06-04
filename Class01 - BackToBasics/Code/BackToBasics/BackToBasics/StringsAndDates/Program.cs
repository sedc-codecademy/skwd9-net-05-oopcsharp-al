using System;

namespace StringsAndDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstSentence = "Hello SEDC!";
            string secondSentence = "Goodbye SEDC!";

            //string concatenation
            Console.WriteLine(firstSentence + " " + secondSentence);

            //string interpolation
            Console.WriteLine($"First:{firstSentence} Second:{secondSentence}");

            //escaping special characters
            Console.WriteLine($"\\ {firstSentence}, \"");
            Console.WriteLine(@$"\ {firstSentence}, """);

            Console.WriteLine(String.Format("First:{0} Second:{1}", firstSentence, secondSentence));


            string stringWithEmptySpaces = "    Hello SEDC    ";
            Console.WriteLine(stringWithEmptySpaces);
            //removing empty spaces on start and at the end
            Console.WriteLine(stringWithEmptySpaces.Trim());

            string realValue = stringWithEmptySpaces.Trim();
            Console.WriteLine(realValue.Length);
            Console.WriteLine(realValue.ToUpper());
            Console.WriteLine(realValue.ToLower());

            string sentence = "Hello, we are learning C#";
            string[] words = sentence.Split(' ');
            foreach(string word in words)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("======================");

            DateTime date = new DateTime();
            Console.WriteLine(date);
            Console.WriteLine(DateTime.Now);

            DateTime newYearsDay = new DateTime(2021, 12, 31);
            Console.WriteLine(newYearsDay);

            DateTime christmas = newYearsDay.AddDays(7);
            DateTime backInTime = newYearsDay.AddDays(-6);
            Console.WriteLine(christmas);
            Console.WriteLine(backInTime);

            Console.WriteLine("Enter your birthday");
            string input = Console.ReadLine();

            DateTime birthday;
            bool successfullyParsed = DateTime.TryParse(input, out birthday);
            if (successfullyParsed)
            {
                Console.WriteLine("Thank you!");
                Console.WriteLine($"You were born on {birthday.ToShortDateString()}");
            }
            else
            {
                Console.WriteLine("Wrong input");
            }

            Console.ReadLine();
        }
    }
}
