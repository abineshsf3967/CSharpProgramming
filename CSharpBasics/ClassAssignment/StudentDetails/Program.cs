using System;
namespace StudentDetails;

class Program
{
    public static void Main()
    {
        System.Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        System.Console.Write("Enter age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Enter the mark of subject 1: ");
        int mark1 = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Enter the mark of subject 2: ");
        int mark2 = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Enter the mark of subject 3:");
        int mark3 = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Enter the grade: ");
        int total = mark1+mark2+mark3;
        float average = (float)total/3;
        char grade = Convert.ToChar(Console.ReadLine());
        System.Console.Write("Enter the Mobile Number: ");
        long mobileNumber = Convert.ToInt64(Console.ReadLine());
        System.Console.Write("Enter the Email Id: ");
        string emailId = Console.ReadLine();
        System.Console.Write("Enter the CGPA: ");
        float cgpa = float.Parse(Console.ReadLine());
        System.Console.WriteLine("Trainee Details are:");
        System.Console.WriteLine("Name: "+name);
        System.Console.WriteLine("Age: "+age);
        System.Console.WriteLine("Mobile: "+mobileNumber);
        System.Console.WriteLine("Marks1: "+mark1);
        System.Console.WriteLine("Marks1: "+mark2);
        System.Console.WriteLine("Marks1: "+mark3);
        System.Console.WriteLine("Total: "+total);
        System.Console.WriteLine("Average: "+Math.Round(average,2));
        System.Console.WriteLine("Grade: "+grade);
        System.Console.WriteLine("Enter the EmailId: "+emailId);
        System.Console.WriteLine("CGPA: "+cgpa);
    }
}