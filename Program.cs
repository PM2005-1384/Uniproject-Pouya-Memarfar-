using System;
using System.Collections.Generic;
int m,n;
do
{
    Console.WriteLine("What's m? ");
    m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("What's n? ");
    n = Convert.ToInt32(Console.ReadLine());

if (n <= m)
{
    Console.WriteLine("sorry! n is not greater than m");
}
}while ( n <m);
var prime_numbers = new List<int>();
for (int i = m + 1; i < n; i++)
{
if (CheckPrime(i))
{
prime_numbers.Add(i);
}
}
if (prime_numbers.Count == 0)
{
    Console.WriteLine("there are no prime numbers");
}
else
{
    Console.WriteLine($"here are the pirme numbers between {m} and {n} : " + string.Join(",", prime_numbers));
}
bool CheckPrime(int number)
{
    if (number < 2) return false;
    for (int i = 2; i * i <= number; i++)
{
    if (number % i == 0)
{
    return false;
}
}
    return true;
}

Console.WriteLine("Press any key to exit the program");
Console.ReadKey();