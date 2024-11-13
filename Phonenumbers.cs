using System;
using System.Collections.Generic;
using System.Linq;

    Console.WriteLine("please enter your text, the program will extract the phone numbers in a moment");
    Console.ReadLine();

var phone_numbers = new List<string>();

foreach (var number in phone_numbers)
{
    if (number.Length == 10 && number.StartsWith('0') && number.Distinct().Count() == 10)
    {
        phone_numbers.Add(number);
    }

}
    Console.WriteLine("here are the phone numbers from the written text:");
foreach (var phone_number in phone_numbers)
{
    Console.WriteLine(phone_number);
}


