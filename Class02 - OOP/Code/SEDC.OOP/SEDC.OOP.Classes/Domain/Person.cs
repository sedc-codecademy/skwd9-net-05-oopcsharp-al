using System;

namespace SEDC.OOP.Classes.Domain
{
    //Properties (Data)
    //Every instance of this class can have FirstName, LastName, Age.....
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Profession { get; set; }
        private string Password { get; set; }
        //Default constructor explicitly specified
        //If we want to instantiate object with empty constructor
        public Person()
        {
            Console.WriteLine("Default constructor called..");
            Password = "123";
        }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Profession = "Not defined";
        }

        public Person(string firstName, string lastName, int age, string profession)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Profession = profession;
        }
        //Methods (Behavior)
        //Every instance of this class can have different behavior like
        //Every instance can Eat, can Sleep, can Work
        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} is {Age} old, and works as {Profession}");
        }
        public void Sleep(int timeFrom, int timeTo)
        {
            Console.WriteLine($"{FirstName} {LastName} sleeps from {timeFrom} till {timeTo}");
        }

        public string Work()
        {
            return $"{FirstName} {LastName} works hard as {Profession}";
        }
        public void Eat(string meal)
        {
            Console.WriteLine($"{FirstName} {LastName} eats {meal}");
        }

        public bool SetPassword(string password)
        {
            if (string.IsNullOrEmpty(password)) // if(password == null || password == "")
            {
                return false;
            }
            Password = password;
            return true;
        }
    }
}
