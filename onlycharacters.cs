using System;
using System.Collections.Generic;

    Console.WriteLine("Enter your characters (type 'quit' to exit the program):");
var only_char = new List<string>();
while (true)
{

    string? input = Console.ReadLine();

if (input == null || input.ToLower() == "quit") break;

if (CheckChar(input))
{
    only_char.Add(input);
}
else
{
    Console.WriteLine("sorry, it's not a character");
}

}
    Console.WriteLine("here are the entered characters:");
foreach (var character in only_char)
{
    Console.WriteLine(character);
}
bool CheckChar(string input)
{
   foreach (char c in input)
   {
    if (!char.IsLetter(c))
    {
        return false;
    }
   }
       return true;

}
