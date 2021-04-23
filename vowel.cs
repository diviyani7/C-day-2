using System.IO;
using System;
class Class1
{
    static void Main()
    {
        Console.WriteLine("Enter a String");
        int vowel = 0, cons = 0;
        string inputString = Console.ReadLine();
       for(int index = 0; index < inputString.Length; index++)
       {
           if(inputString[index]=='a' || inputString[index]=='e'||
           inputString[index]=='i'|| inputString[index]=='o'||inputString[index]=='u')
       {
           vowel++;
       }
       }
    Console.WriteLine("Total Number of vowel: {0}", vowel);
    Console.ReadLine();
    }
}