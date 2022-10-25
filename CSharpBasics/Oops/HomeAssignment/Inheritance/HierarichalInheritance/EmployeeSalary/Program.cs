using System;
namespace EmployeeSalary;
class Program
{
    public static void Main(string[] args)
    { 
       PermanentEmployee employee=new PermanentEmployee(1000,2,"Permanaent");
       employee.ShowSalary();
       System.Console.WriteLine();
       TemporaryEmployee temp=new TemporaryEmployee(1200,4,"Temporary");
       temp.TempSalary();
    }
}
