using System.IO;
using System;

class Class2
{
    void CheckOddEven(int a)
    {
        if(a % 2 == 0)
        {
        Console.WriteLine("Number is Even");
        }
        else
        {
          Console.WriteLine("Number is odd");  
        }
    }
    static void Main()
    {
        Class2 class1 = new Class2();
        class1.CheckOddEven(6);
        Console.ReadLine();
    }
       
}