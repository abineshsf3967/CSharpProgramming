using System;
namespace DepartmentDetails;
class Program
{
    public static void Main(string[] args)
    {
        BookInfo book=new BookInfo("ECE","BE","C#","Abinesh",200);
        book.ShowBook();
    }
}
