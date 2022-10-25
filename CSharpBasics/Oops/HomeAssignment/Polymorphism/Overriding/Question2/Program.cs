using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        FreeLancer employee=new FreeLancer("Abinesh","Palanisamy",Gender.Male,"BE","Developer",30);
        employee.CalculateSalary();
        employee.Display();
        System.Console.WriteLine();
        SyncFusion employee1=new SyncFusion("Abinesh","Palanisamy",Gender.Male,"BE","Developer",30,"Mathura");
        employee1.CalculateSalary();
        employee1.Display();
    }
}