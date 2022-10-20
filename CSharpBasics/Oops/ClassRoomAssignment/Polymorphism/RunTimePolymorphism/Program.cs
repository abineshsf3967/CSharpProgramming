using System;
namespace RunTimePolymorphism;
class Program
{
    public static void Main(string[] args)
    {
        Total total=new Total();
        Sport sport=new Sport();
       
       
        Student student;
        student=total;
        student.Name="abi";
        student.Display();

        student=sport;
        student.Name="abi";
        student.Display();
    }
}
