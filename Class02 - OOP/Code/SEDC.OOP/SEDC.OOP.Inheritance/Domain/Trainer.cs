using System;
using System.Collections.Generic;

namespace SEDC.OOP.Inheritance.Domain
{
    //Class Trainer inherits from Person
    public class Trainer : Person
    {
        public int YearsOfExperience { get; set; }
        public List<string> ProgrammingLanguages { get; set; }

        //Constructor of the Trainer class that inherits the base() constructor from the parent class
        public Trainer(string firstName, string lastName, int age, string phone, int yearsofExp)
            : base(firstName, lastName, age, phone)
        {
            YearsOfExperience = yearsofExp;
            ProgrammingLanguages = new List<string>();
        }

        //Override of the method PrintInfo() that is inherited from the Person parent class
        public override void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} - {Age}, has {YearsOfExperience} years of experience");
        }
    }
}
