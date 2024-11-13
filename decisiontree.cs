using System;

    Console.WriteLine("Enter the your subject (math, science)");
    var answer = Console.ReadLine();

if (answer?.ToLower() == "math")

   
   Console.WriteLine("which type of math? (algebra , geometry)");
if (answer?.ToLower() == "algebra")
    Console.WriteLine("you are intersted in mathmatical funtcions and calculating");
else
    Console.WriteLine("you are interseted in sloving problems about shape");

if (answer?.ToLower() == "science")
    Console.WriteLine("which type of science (physics, chemistry, biology)");

if (answer?.ToLower() == "physics")
    Console.WriteLine("you are intersted in studying about how things work");
else if (answer?.ToLower() == "chemistry")
    Console.WriteLine("you are intersted in how atoms works and how materials are made");
else
    Console.WriteLine("you are intersted in how every living beings can live and how their organs function");

