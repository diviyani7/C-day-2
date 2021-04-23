using System.IO;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter some value");
        var x=Console.ReadLine();
        Console.WriteLine(x);
        Console.WriteLine(x.GetType());
        Console.ReadLine();
    }
}