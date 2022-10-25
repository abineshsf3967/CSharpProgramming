using System;
namespace LibraryInfo;
class Program
{
    public static void Main(string[] args)
    {
        BookInfo book=new BookInfo("ECE","BE","Abinesh","Ravi",400);
        book.DispalyBook();
    }
}