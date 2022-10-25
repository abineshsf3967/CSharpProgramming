using System;
namespace EmployeePortal;
class Program
{
    public static void Main(string[] args)
    {
        SalaryInfo salary=new SalaryInfo("Abinesh","Palanisamy",Gender.Male,6382600921,new DateTime(2000,11,12),DateTime.Now,8,400,10);
        salary.Salary();
    }
}