using SEDC.OOP.Inheritance.Domain.Enums;
using System;
using System.Collections.Generic;

namespace SEDC.OOP.Inheritance.Domain
{
    public class Student : Person
    {
        public string Group { get; set; }
        public List<string> Subjects { get; set; }
        public AcademyType AcademyType { get; set; }

        //Constructor of the Student class that calls the base() constructor from the parent class
        public Student(string firstName, string lastName, int age, string phone, string group, AcademyType academy)
            : base(firstName, lastName, age, phone)
        {
            Group = group;
            AcademyType = academy;
            Subjects = new List<string>();
        }

        //Override of the method PrintInfo() that is inherited from the Person parent class
        public override void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} - {Age}. Is student in group {Group}");
        }
    }
}
