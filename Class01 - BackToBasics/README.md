# Back to basics 🪂
## Types and variables 🔹
* Variables must be declared with their type before hand
* Variables can be declared and instantiated at the same time
* Variables always exist in a certain type
* A variable that is of certain type can't hold data from another type
* There can't be variables with the same name in the same scope
* Strings are written with **" "** and characters with **' '**
### Variables 
```csharp
int num = 5; // Integers only
string words = "Hello people"; // String of characters only ( Watch the quotations )
char letter = 'P'; // One character only ( Watch the quotations )
bool falsy = false; // Boolean ( True or FalsE ) only
double deci = 0.2; // Decimal numbers only
num = "Hey"; // This will be marked as an error since 
Console.WriteLine(num.GetType()); // Find out what type some variable is
Console.WriteLine(num.GetType().Name); // Find out what type some variable is without the namespace
```
### Converting values
* Data of certain type can try and be converted to other type
* Parse method tries to convert a value from one to another type
* If Parse fails, it throws an error
* Parse returns the converted value
* TryParse tries to convert and gives info if it succeeded
* TryParse do not throw an error when the type can't be converted
* TryParse returns bool with true if the conversion was successful and false if it was not
* TryParse needs another variable that needs to be created, that can hold the converted value if TryParse succeeds and is connected by an out parameter
```csharp
// Using Parse method
int parseInt = int.Parse("23");
double parseDouble = double.Parse("23.5");

// Using TryParse method
// If the converting is successful the value will be written here
int ifParsedValue; 
// A boolean variable that will keep info if the parsing was successful or not
bool parsingSuccsess = int.TryParse("25", out ifParsedValue);
Console.WriteLine(parsingSuccsess); // true
```
### Reading and Writing in the Console
* C# Console application always returns a string when it accepts an input from a user
* Inputs need to be converted to other types if we expect other types
* Console.Write() writes a line of text without entering a new line after the text
* Console.WriteLine() writes a line of text and after it, it starts a new line
* Console.Read() asks the user to input a value and does not add a new line after the user entered the input
* Console.ReadLine() asks the user to input a value and will add a new line after the user entered the input
* Console can be cleared by typing Console.Clear()
* Console can also be in different colors
```csharp
Console.WriteLine("Enter your name:");
string name = Console.ReadLine();
Console.WriteLine("Hello there " + name + "!");
```
## Conditional Statements 🔹
* Conditional statements are used to represent making decisions in code
* Conditional statements always ask a question and the question must have a true or false answer
* If the answer is true, it executes something
* If the answer is false, it skips the piece of code
* If there is an Else statement, that will get executed if no if statement is executed
* There can be an if statement without else
* There can be multiple if statements one after the other - All of them will get checked if they are true
* There can be multiple if else statements one after the other - The first one that returns true will get executed and all others will be skipped
* There can be an if statement nested inside of another if statement - The first needs to be true in order for the inner if to even get a chance to be checked if it is true or false
* Anything that provide a true or false value is valid for an if statement
### If - Else
```csharp
// If / Else 
if (5 > 3)
{
	Console.WriteLine("5 is larger than 3");
}
else
{
	Console.WriteLine("5 is not larger than 3"); 
}

// Switch 
int day = 3;
```
### Switch
* Switch tests a value in multiple cases in a short and easy way
* After every case with implementation we need to write break so that the other cases are not tested aimlessly 
* Cases can be bundled by writing them one after the other without any implementation - The one that has implementation will represent all above cases that do not have implementation
* Usually used when we have one value but we expect to yield more choices as a result
* If a default case exists, it will get execute if NO other case is a match
```csharp
switch (day)
{
	case 1:
	case 2:
	case 3:
	case 4:
	case 5:
	Console.WriteLine("Work day :(");
	break;
	case 6:
	case 7:
	Console.WriteLine("WEEKEND! WOHO!");
	break;
	default:
	Console.WriteLine("There is no such day! Sorry!");
	break;
}
```
## Loops 🔹
* Loops are structures that can run a code multiple times
* The code that is executed is the same code, executed over and over again
* To count how many times a loop ran a code, we use counters
* Loops ask statements in order to determine if the need to loop again or stop
* If a statement is true, the loop will run again
* If a statement is false, the loop stops looping and the code continues
* There are different types of loops and all of them have a use-case
* We can use loops to do something multiple times dynamically 
* We can also use loops with collections to easily work with them
* Convention for a counter is i, j and k names
* The counter can be incremented while the loop is running and a scenario where some statement involves the counter
### For loop
* For loop is the best loop for counting
* It is great because the counter of the loop is implemented in the loop directly
* The counter also lives only inside the loop, so it does not pollute our code
```csharp
Console.WriteLine("Counting to 10...");
for(int i = 1; i <= 10; i++){
	Console.WriteLine("Counter is now:" + i);
}
Console.WriteLine("Done counting!");
Console.ReadLine();
```
### While loop
* While loop is great for handling scenarios with unknown outcome and result
* While can ask a question over and over again until the question yields some result
* It is usually used for inputs such as inputs from user or data from a server. 
```csharp
Console.WriteLine("Counting to 10...");
int j = 1;
while(j <= 10){
	Console.WriteLine("Counter is now:" + j);
	j++;
}
Console.WriteLine("Done counting!");
Console.ReadLine();
``` 
## Collections 🔹
* In programming collections are the structures where we can keep multiple values at once organized by one name
* Collections in C# must have a type most of the time because C# is strictly typed language
* There are multiple types of collections in C#
* Arrays are one type of collection that is mostly used in non object oriented related code
* Generic collections are usually used for object oriented code
* Collections such as list or array are indexed
* Indexes are the numbers on the items on the collections representing in which place the item exists in the collection
* Counting indexes in C# always starts from 0
* First item will have 0 index, second 1 etc
### List and Dictionary
* List is an indexed collection
* List is also generic collection
* We can add as much items as we want in a list
* There is also a Remove method 
* To check the number of items in a list, Count is used
* Dictionaries are collections that keep items like key-value pairs
* Key value pairs are combinations of 2 values which the first is always key and the second value
* Dictionary does not have indexes
* Items can be found in a Dictionary by the Key
```csharp
// Create an empty list of strings
List<string> names = new List<string>();
// Add stuff to the list
names.Add("Bob");
names.Add("Midge");
names.Add("Red");
// Remove stuff from the list
names.Remove("Red");
// Find stuff from the list
names.Find("Midge");
// Number of elements
names.Count;
// Create and initialize a list of numbers
List<int> numbers = new List<int>(){ 2,89,4,8,6 };
```
```csharp
// Create an empty dictionary
Dictionary<int, string> people = new Dictionary<int,string>();
// Add stuff to the dictionary
people.Add(1,"Bob");
people.Add(2,"Midge");
people.Add(3,"Red");
// Remove items by key value
people.Remove(3); // removes Red
// Find if a key exists
people.ContainsKey(2);
// Find if a value exists
people.ContainsValue("Midge");
// Number of elements
people .Count;
// Get value by key from a dictionary
people[1]; // this will return "Bob"
// Create and initialize a dictionary
Dictionary<string, bool> CheckList = new Dictionary<string, bool>(){ 
{"Potatoes", false},
{"Butter", true},
{"Salt", false},
{"Pepper", false}
};
// Getting first checklist item key and value
CheckList.First().Key // Returns "Potatoes"
CheckList.First().Value // Returns false
```
### Looping collections
* Going through a whole collection can be done with loops
* Loops can go through an array by utilizing the counter as a number that can also serve as an index
* For collections without indexes ForEach can be used
```csharp
List<string> names = new List<string>() {"Bob", "Jill", "Greg"};
Console.WriteLine("Writing names...");
for(int i = 0; i < names.Length; i++){
	Console.WriteLine(names[i]);
}
Console.ReadLine();
```
### ForEeach
* ForEach can go through collections automatically, without us writing counters
* It goes through every item in an array and for each cycle, it replaces the item variable inside of it to match the item that is in turn
* ForEach is great for going through collections completely 
```csharp
List<string> names = new List<string>() {"Bob", "Jill", "Greg"};
Console.WriteLine("Writing names...");
foreach(string name in names){
	Console.WriteLine(name);
}
Console.ReadLine();
```

## String methods 🔹
### String building
* Strings can be built in different ways in C#
* The normal way is by concatenating them with the + sign
* Different type concatenating with a string will result in a string
* There is a method ToString() that converts a value in to string
* There is another way of writing and combining strings
* By writing $ sign before the string, we can write { } brackets and write other values in them - A feature called interpolation
```csharp
string hello1 = "Hello " + name;
string hello2 = string.Format("Hello {0}", name);
string hello3 = $"Hello {name}";
```
### Manipulating with strings
* Strings can be changed or manipulated with built in methods 
* These built in methods are usually called on the string it self and can be chained
```csharp
string ourString = "   We are learning C# and it is FUN and EASY. Okay maybe just FUN.    ";
Console.WriteLine(ourString);

// Makes our string Upper/Lower Case
string lowe = ourString.ToLower();
Console.WriteLine(lowe);
string upper = ourString.ToUpper();
Console.WriteLine(upper);

// Prints the length of our string
int ourLength = ourString.Length;
Console.WriteLine(ourLength);

// Splits the string and makes an array of strings (splits on character selected)
string[] splited = ourString.Split('.');
Console.WriteLine(splited[0]);
Console.WriteLine(splited[1]);
Console.WriteLine(splited[2]);
// The line below is commented because there is no index 3 in our splited array
//Console.WriteLine(splited[3]);

// Checks if a string starts with some string given and returns true or false
bool startsWith = ourString.StartsWith("   W");
Console.WriteLine(startsWith);

// Checks if a string exists and if so returns an index, if not -1
int indexOfString = ourString.IndexOf("FUN");
int nonExistingString = ourString.IndexOf("Nope");
Console.WriteLine(indexOfString);
Console.WriteLine(nonExistingString);

// Cuts the string in to a substring that starts from index 5 and takes the next 16 characters
string substring = ourString.Substring(5, 16);
Console.WriteLine(substring);

// It trims the white spaces at the front and back of the string
string trimmedString = ourString.Trim();
Console.WriteLine(trimmedString);
```
## DateTime methods 🔹
### What is DateTime
* For representing time and dates in C#, a special type is used called DateTime
* DateTime by default does not hold a date, but an empty date that can be a problem for systems that can't accept empty dates such as databases 
* DateTime has a constructor that accepts an year, month, day parameters
* DateTime can be called with Today or Now to get the current date or current date and time
* DateTime types can be parsed in to string and back from a string, but a format must be followed
* There are a lot of methods that can manipulate DateTime, adding, removing or getting days, months or years
```csharp
DateTime aDate = new DateTime(); // Creating a new empty date
DateTime aCustomDate = new DateTime(1992, 10, 15); // Creating a custom date
DateTime currentDay = DateTime.Today; // Getting todays date without time
DateTime currentDateTime = DateTime.Now; // Getting todays date with time
```
### Parsing DateTime
```csharp
string stringDate = "12-15-2012"; 
DateTime convertedDate = DateTime.Parse(stringDate); // Converting string to date
```
### Working with DateTime
```csharp
DateTime  currentDateTime  =  DateTime.Now;

// Adding or removing days to a DateTime date
DateTime addedDays = currentDateTime.AddDays(2);
Console.WriteLine(addedDays);
DateTime removedDays = currentDateTime.AddDays(-5);
Console.WriteLine(removedDays);

// Adding months to a DateTime date
DateTime addedMonths = currentDateTime.AddMonths(2);
Console.WriteLine(addedMonths);

// Adding years to a DateTime date
DateTime addedYears = currentDateTime.AddYears(2);
Console.WriteLine(addedYears);

// Adding hours to a DateTime date
DateTime addedHours = currentDateTime.AddHours(3);
Console.WriteLine(addedHours);

// Get the number of the month from a DateTime
int month = currentDateTime.Month;
Console.WriteLine(month);

// Get the number of the day from a DateTime
int day = currentDateTime.Day;
Console.WriteLine(day);

// Get the number of the year from a DateTime
int year = currentDateTime.Year;
Console.WriteLine(year);
```
## Building methods from scratch 🔹
### Why methods
* Methods are named blocks of code that can be executed multiple times
* Methods in C# must have a strict return type meaning that every method must define what type will be the return value
* If nothing is returned from a function, the return type is void
* If there is a certain return type, a value of that type must be returned otherwise, there will be an error
* Parameters must also be defined by a certain type
* When the method is called, the types that are passed must correspond to the parameter types that were defined, otherwise it will throw an error
* Methods are a great way to organize, bundle and create reusable and scalable code
### Method structure in C#
```csharp
// The type before the name is the return type
// public and static will be discussed in next classes
public static string SayHello(string name){
	string result = $"Hello there {name}!";
    return result;
}
// Void function that does not return anything
public static void SayBye(){
	Console.WriteLine("Byeeeee!");
}
```
