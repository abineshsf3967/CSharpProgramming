using System;
namespace Overriding;
class Program
{
    public static void Main(string[] args)
    {
        Library student=new Library();
        student.BookInfo("Abinesh","C#","Prithish",2018);
        student.Display();

        System.Console.WriteLine();

        EEEDepartment department=new EEEDepartment();
        department.BookInfo("Prithis","C#","Abinesh",2019);
        department.Display();

    }
}