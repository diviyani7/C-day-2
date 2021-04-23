using System.IO;
using System;

public struct Person
    {
        public String Name {get; set;}
        public Person(string _name)
        {
            Name = _name;
        }
    }

public struct Dog 
{
 public String Breed {get; set;}
public  Dog(string _breed)
{
    Breed = _breed;
}
}
class Class6
{
   public static void showvalue(Object o)
   {
       if(o is Person p)
       {
           Console.WriteLine(p.Name);
       }
       else if(o is Dog)
       {
           Console.WriteLine(d.Breed);
       }
   }
   static void Main()
   {

       Object o =new Person("Diviyani");
       showvalue(o);
       o= new Dog("Bomerian");
       showvalue(o);
       Console.ReadLine();
   }
}