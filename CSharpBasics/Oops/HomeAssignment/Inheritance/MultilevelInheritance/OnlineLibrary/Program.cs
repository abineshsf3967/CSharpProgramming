using System;
namespace OnlineLibrary;
class Program
{
    public static void Main(string[] args)
    {
        BookInfo book=new BookInfo("ECE","BE",2,3,"C#","Abinesh",2000);
        book.ShowBookInfo();
    }
}
