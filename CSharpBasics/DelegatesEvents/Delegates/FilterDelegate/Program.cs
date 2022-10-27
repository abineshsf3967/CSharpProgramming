using System;
using System.Collections.Generic;
namespace FilterDelegate;
public delegate bool Filter(Person p);
class Program
{
    public static void Main(string[] args)
    {
        Person person1=new Person() {Name="abi",Age=20};
        Person person2=new Person() {Name="Ravi",Age=30};
        Person person3=new Person() {Name="Ram",Age=10};
        Person person4=new Person() {Name="Baskaran",Age=35};
        Person person5=new Person() {Name="abinesh",Age=80};
        List<Person> people=new List<Person>(){person1,person2,person3,person4,person5};
        Display("Children",people,IsChild);
        Display("Adult",people,IsAdult);
        Display("Senior",people,IsSenior);
        

    }

    static void Display(string title,List<Person> people,Filter filter)
    {
        System.Console.WriteLine("People in "+title+"list are: ");

        foreach(Person p in people)
        {
            if(filter(p))
            {
                System.Console.WriteLine($"{p.Name} is {p.Age} years old");
            }
        }
    }

    static bool IsChild(Person p){return p.Age<15;}
    static bool IsAdult(Person p){return p.Age>=18 && p.Age<=40;}
    static bool IsSenior(Person p){return p.Age>50;}

}
