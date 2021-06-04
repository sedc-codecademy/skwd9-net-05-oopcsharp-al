using System;

namespace Methods
{
    class Program
    {
        //method with one string parameter and return type string
        public static string GetGreeting(string name)
        {
            return $"Hello {name}";
            
        }
        //method with no parameters and no return type
        public static void SayGoodbye()
        {
            Console.WriteLine("Goodbye all");
        }
        static void Main(string[] args)
        {
            string message = GetGreeting("SEDC");
            Console.WriteLine(message);
            SayGoodbye();
            Console.ReadLine();
        }
    }
}
