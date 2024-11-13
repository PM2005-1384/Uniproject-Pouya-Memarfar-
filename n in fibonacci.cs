using System;
int n;
do
{
    Console.WriteLine("what's n? ");
    n = Convert.ToInt32(Console.ReadLine());
if (n < 0)
{
    Console.WriteLine("oops!! it seems you put a negative number! try again! ");
}

} while (n < 0);
bool Is_n_in_Fibo = CheckFibo(n);

if (Is_n_in_Fibo)

{
    Console.WriteLine($"{n} is in the Fibonacci sequence");
}
else
{
    Console.WriteLine($"{n} is not in the Fibonacci sequence");
}
bool CheckFibo(int x)
{
  if (x == 0 || x == 1)
  return true;
  int a1 = 0;
  int a2 = 1;
  int fibo = 0;

  while (fibo < x)
  {
  fibo = a1 + a2;
  a1 = a2;
  a2 = fibo;
  }
  return fibo == x;
}

Console.WriteLine("Press any key to exit the program");
Console.ReadKey();