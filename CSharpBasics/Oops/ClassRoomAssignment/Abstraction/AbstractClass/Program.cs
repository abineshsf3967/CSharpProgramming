using System;
namespace AbstractClass;
class Program
{
    public static void Main(string[] args)
    {
        Syncfuison job1=new Syncfuison();
        job1.Name="Developer";
        job1.Salary(15);


        TCS job2=new TCS();
        job2.Name="Testing Engineer";
        job2.Salary(30);

    }
}
