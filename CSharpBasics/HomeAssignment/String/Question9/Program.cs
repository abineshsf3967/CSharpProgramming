using System;
namespace Question9;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string: ");
        string word=Console.ReadLine();
        System.Console.WriteLine("Enter the substring: ");
        string search=Console.ReadLine();
        bool get=word.Contains(search);
        if(get==true)
        {
            System.Console.WriteLine("The substring is exists in the string");
        }
        else
        {
            System.Console.WriteLine("The substring is not exists in the string");
        }
    }
}
