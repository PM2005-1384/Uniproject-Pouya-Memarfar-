using System;
using System.Collections.Generic;
int m,n;
do
{
    Console.WriteLine("Whta's m?");
    m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("What's n? ");
    n = Convert.ToInt32(Console.ReadLine());
if (n <=m)
{
    Console.WriteLine("oops!! n is not greater then m!! try again");
}
} while (n <=m);
var mirror_numbers = new List<int>();
for (int i = m + 1; i < n; i++)
{
if (CheckMirror(i))
{
mirror_numbers.Add(i);
}
}
if (mirror_numbers.Count==0)
{
    Console.WriteLine("There are no mirror numbers");
}
else
{
    Console.WriteLine($"mirror numbers between {m} and {n} are : " + string.Join(",", mirror_numbers));
}
bool CheckMirror(int number)
{
    int original = number;
    int reversed = 0;
    while (number>0)
    {
        int digit = number % 10;
        reversed = reversed * 10 + digit;
        number /= 10;
    }
    return original == reversed ;
}

Console.WriteLine("Press any key to exit the program");
Console.ReadKey();
