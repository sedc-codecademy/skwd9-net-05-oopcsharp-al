using SEDC.OOP.Classes.Domain;
using System;

namespace SEDC.OOP.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person tanja = new Person();
            tanja.FirstName = "Tanja";
            //tanja.Password = "123"; -> private
            tanja.LastName = "Stojanovska";
            tanja.Age = 27;
            tanja.Profession = "Web developer";

            tanja.PrintInfo();
            tanja.Eat("Pizza");
            tanja.Sleep(11, 7);
            Console.WriteLine(tanja.Work());

            Person martin = new Person()
            {
                FirstName = "Martin",
                LastName = "Panovski",
                Age = 27,
                Profession = "Web developer"
            };
            martin.Eat("Burger");
            martin.PrintInfo();

            Person marko = new Person("Marko", "Petkovski", 25);
            marko.PrintInfo();
            marko.Sleep(24, 6);
            marko.Eat("Cake");

            bool isPasswordSet = marko.SetPassword("123");

            bool isTanjasPasswordSet = tanja.SetPassword(null);
            Console.WriteLine(isPasswordSet);

            Console.ReadLine();
        }
    }
}
