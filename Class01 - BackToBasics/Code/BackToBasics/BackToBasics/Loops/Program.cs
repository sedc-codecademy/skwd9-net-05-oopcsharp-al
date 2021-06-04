using System;
using System.Collections.Generic;
using System.Linq;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //count to 3
            for(int i = 1;i <= 3; i++)
            {
                Console.WriteLine($"The value of the counter is {i}");
            }

            //count to 5
            int k = 1;
            while(k <= 5)
            {
                Console.WriteLine($"The value of the counter is {k}");
                k++;
            }

            //loop while we enter end
            string input = "";
            while(input != "end")
            {
                Console.WriteLine("Enter input:");
                input = Console.ReadLine();
            }

            Console.WriteLine("=====================");

            //Declaration and initialization of new list of ints
            List<int> integerList = new List<int> { 3, 67, 98 };
            Console.WriteLine(integerList.Count);
            integerList.Add(7);
            Console.WriteLine(integerList.Count);
            integerList.Remove(3);
            integerList.Remove(98);
            Console.WriteLine(integerList.Count);

            Console.WriteLine(integerList[1]);
            foreach(int item in integerList)
            {
                Console.WriteLine(item);
            }
            integerList.AddRange(new List<int> { 2, 3, 5 });
            Console.WriteLine("After adding range");
            foreach (int item in integerList)
            {
                Console.WriteLine(item);
            }

            //DICTIONARY
            //Declaration of dictionary and populating with data by using method Add()
            Dictionary<string, long> phoneBook = new Dictionary<string, long>();
            phoneBook.Add("Tanja", 5554444333);
            phoneBook.Add("Martin", 7989844589);
            phoneBook.Add("Marko", 367436467);
            foreach(var item in phoneBook)
            {
                Console.WriteLine($"Key: {item.Key} - Value: {item.Value}");
            }

            Dictionary<string, List<string>> academy = new Dictionary<string, List<string>>();
            academy.Add("G1", new List<string> { "Marko", "Ana", "Petar" });
            academy.Add("G2", new List<string> { "Aleksandar", "Bojana", "Marija" });
            foreach(var item in academy)
            {
                Console.WriteLine(item.Key);
                foreach(string value in item.Value)
                {
                    Console.WriteLine(value);
                }
            }

            //LINQ
            List<string> names = new List<string> { "Aleksandar", "Bojana", "Marija" };
            Console.WriteLine(names.First());
            Console.WriteLine(names.LastOrDefault());

            List<string> filteredNames = names.Where(x => x == "Aleksandar").ToList();

            //Filtering a dictionary with Where() and then selecting only the value by using Select()
            long martinsPhonenumber = phoneBook
                                .Where(x => x.Key == "Martin")
                                .Select(x => x.Value)
                                .First();

            Console.ReadLine();
        }
    }
}
