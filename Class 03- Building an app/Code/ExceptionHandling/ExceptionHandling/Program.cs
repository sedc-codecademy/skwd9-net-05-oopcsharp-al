using ExceptionHandling.Domain;
using ExceptionHandling.Exceptions;
using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            //Build time error
            //int number = "Hello World";

            try
            {
                //User tanja = null;
                User tanja = new User
                {
                    FirstName = "Tanja",
                    LastName = "Stojanovska",
                    Age = 27
                };
                Console.WriteLine(tanja.FirstName);

                Console.WriteLine("Enter a number");
                string input = Console.ReadLine();
                int number = int.Parse(input);


                //we can throw an Exception
                //throw new Exception("This is our own error");

                //we can throw our custom exception
                throw new OurException("Our error occured");

                //this line will not be reached, if an exception occurs above
                Console.WriteLine("End of try block");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("You can not use properties or methods from object with value null");
            }
            catch(FormatException e)
            {
                Console.WriteLine("Input was in incorrect format");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occcured");

                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("This code will execute anyway!");
                Console.WriteLine("End of program");
            }

            Console.ReadLine();
        }
    }
}
