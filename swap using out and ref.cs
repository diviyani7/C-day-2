using System.IO;
using System;

class Class3

{

    void Swap(out int a, ref int b)
    {
      
     Console.WriteLine(" After swap fun");
     a = 0;
        
    }
   
    static void Main()
    {
        Class3 Class1 = new Class3(); 
        int a=5, b=6;
         Console.WriteLine("Inside Main fun");
        Console.WriteLine("a= "+a);
        Class1.Swap(out a,ref b);
         Console.WriteLine("a="+a);
        
        Console.ReadLine();
    }   
}