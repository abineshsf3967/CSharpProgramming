using System;
namespace Question9;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the month: ");
        string month=Console.ReadLine().ToLower();
        System.Console.WriteLine("Enter the number of leaves taken: ");
        int leaves=int.Parse(Console.ReadLine());
        if(month=="january")
        {
            int workedDays=31-leaves;
            int totalSalary=workedDays*500;
            System.Console.WriteLine("Total salary: "+totalSalary);
        }
        else if(month=="february")
        {
            System.Console.WriteLine("Enter the year: ");
            int year=int.Parse(Console.ReadLine());
            if(year%400==0)
            {
                int workedDaysLeap=29-leaves;
            int totalSalaryLeap=workedDaysLeap*500;
             System.Console.WriteLine("Total salary: "+totalSalaryLeap);
            }
            else if(year%100==0)
            {
                 int workedDaysNotLeap=28-leaves;
            int totalSalaryNotLeap=workedDaysNotLeap*500;
             System.Console.WriteLine("Total salary: "+totalSalaryNotLeap);
            }
            else if(year%4==0)
            {
                int workedDaysLeap1=31-leaves;
            int totalSalaryLeap1=workedDaysLeap1*500;
             System.Console.WriteLine("Total salary: "+totalSalaryLeap1);
            }
        }
        else if(month=="march")
        {
            int workedDays=31-leaves;
            int totalSalary=workedDays*500;
             System.Console.WriteLine("Total salary: "+totalSalary);
        }
        else if(month=="april")
        {
            int workedDays=30-leaves;
            int totalSalary=workedDays*500;
             System.Console.WriteLine("Total salary: "+totalSalary);
        }
        else if(month=="may")
        {
            int workedDays=31-leaves;
            int totalSalary=workedDays*500;
             System.Console.WriteLine("Total salary: "+totalSalary);
        }
        else if(month=="june")
        {
            int workedDays=30-leaves;
            int totalSalary=workedDays*500;
             System.Console.WriteLine("Total salary: "+totalSalary);
        }
        else if(month=="july")
        {
            int workedDays=31-leaves;
            int totalSalary=workedDays*500;
             System.Console.WriteLine("Total salary: "+totalSalary);
        }
        else if(month=="august")
        {
            int workedDays=31-leaves;
            int totalSalary=workedDays*500;
             System.Console.WriteLine("Total salary: "+totalSalary);
        }
        else if(month=="september")
        {
            int workedDays=30-leaves;
            int totalSalary=workedDays*500;
             System.Console.WriteLine("Total salary: "+totalSalary);
        }
        else if(month=="october")
        {
            int workedDays=31-leaves;
            int totalSalary=workedDays*500;
             System.Console.WriteLine("Total salary: "+totalSalary);
        }
        else if(month=="november")
        {
            int workedDays=30-leaves;
            int totalSalary=workedDays*500;
             System.Console.WriteLine("Total salary: "+totalSalary);
        }
        else if(month=="december")
        {
            int workedDays=31-leaves;
            int totalSalary=workedDays*500;
             System.Console.WriteLine("Total salary: "+totalSalary);
        }
        else
        {
            System.Console.WriteLine("Invalid input");
        }
    }
}