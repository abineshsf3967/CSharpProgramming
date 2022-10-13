using System;
namespace StringAssignment;
class Program
{
    public static void Main(string[] args)
    {
         System.Console.WriteLine("Enter the string: ");
         string word=Console.ReadLine();
         System.Console.WriteLine("Enter the substring: ");
         string search=Console.ReadLine();
         string[] split1=word.Split(search);
         int count=0;
        foreach(string check in split1)
        {
            System.Console.WriteLine(check);
            count++;
        }
        System.Console.WriteLine(count-1);
         
    }
   
}