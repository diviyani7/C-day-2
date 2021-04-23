using System.IO;
using System;

class Class3

{

    void Swap(out int a)
    {
      
     Console.WriteLine(" Inside swap function");
     a = 6;
     Console.WriteLine("a= "+a);
        
    }
   
    static void Main()
    {
        Class3 Class1 = new Class3(); 
        int a=5;
        Class1.Swap(out a);
         Console.WriteLine("Inside Main function");
        Console.WriteLine("a= "+a);
       
        Console.ReadLine();
    }   
}
