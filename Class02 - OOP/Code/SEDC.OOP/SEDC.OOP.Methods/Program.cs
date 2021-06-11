using System;
using System.Collections.Generic;

namespace SEDC.OOP.Methods
{
    class Program
    {
        //Method with no parameters and no return type
        public static void Greet()
        {
            Console.WriteLine("Hello SEDC");
        }
        //Method with one input parameter and no return type
        public static void Greet(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
        //Method with input parameters and return type
        public static int Sum(int num1, int num2)
        {
            int result = num1 + num2;
            return result;

            //return num1 + num2;
        }
        public static string CheckRole(string name)
        {
            switch (name) {
                case "Tanja":
                    return $"{name} is presenter";
                case "Martin":
                    return $"{name} is trainer";
                default:
                    return $"{name} does not exist as role";

            }

        }

        public static void PrintStudentNames(List<string> studentNames)
        {
            Console.WriteLine("Students:");
            foreach(string name in studentNames)
            {
                Console.WriteLine(name);
            }
        }
        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        //Method calling a method as a return type
        public static double MultiplyResult(double num1, double num2)
        {
            return Multiply(num1, num2);
        }
        static void Main(string[] args)
        {
            Greet();
            Greet("Ana");
            int resultOfSum = Sum(2, 3);
            string roleInformation = CheckRole("Martin");
            Console.WriteLine(roleInformation);
            Console.WriteLine($"Result of Sum: {resultOfSum}");

            PrintStudentNames(new List<string> { "Ana", "Marko", "Stefan" });
            Console.WriteLine(MultiplyResult(3, 4));

            Console.ReadLine();
        }
    }
}
