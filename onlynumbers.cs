using System;
using System.Collections.Generic;

    Console.WriteLine("Enter your numbers (type 'quit' to exit the program):");
var only_numbers = new List<int>();
while (true)
{

    string? input = Console.ReadLine();

if (input == null || input.ToLower() == "quit") break;

if (int.TryParse(input, out int number))
{
    only_numbers.Add(number);
}
else
{
    Console.WriteLine("sorry, it's not a number");
}

}
    Console.WriteLine("here are the entered numbers:");
foreach (var number in only_numbers)
{
    Console.WriteLine(number);
}





   