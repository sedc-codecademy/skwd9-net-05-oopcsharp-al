using SEDC.OOP.Inheritance.Domain;
using SEDC.OOP.Inheritance.Domain.Enums;
using System;

namespace SEDC.OOP.Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Student aleksandar = new Student("Aleksandar", "Stefkov", 23, "2243234", "G2", AcademyType.WebDevelopment);
            aleksandar.PrintInfo();

            Trainer trainer = new Trainer("Tanja", "Stojanovska", 27, "4345435", 5);
            trainer.PrintInfo();

            Person perosnAna = new Person("Ana", "Petrovska", 34, "634732");
            perosnAna.PrintInfo();

            Person martin = new Student("Martin", "Stefkov", 27, "2243234", "G2", AcademyType.QA);
            martin.PrintInfo();

            Console.ReadLine();
        }
    }
}
