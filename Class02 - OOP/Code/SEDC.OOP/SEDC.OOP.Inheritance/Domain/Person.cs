using System;

namespace SEDC.OOP.Inheritance.Domain
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }

        public Person(string firstName, string lastName, int age, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            PhoneNumber = phoneNumber;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} {Age}");
        }
    }
}
