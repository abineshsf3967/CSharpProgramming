using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the basic Salary: ");
        double basicSalary=double.Parse(Console.ReadLine());
        if(basicSalary<=10000 && basicSalary>0)
        {
            double hra=0.20*basicSalary;
            double da=0.80*basicSalary;
            double monthlySalary=basicSalary+hra+da;
            double annualSalary=12*monthlySalary;
            double tax=0.06*annualSalary;
            double insurance=0.01*annualSalary;
            double annualIncome=(annualSalary-tax-insurance);
            System.Console.WriteLine("Annual Gross salary: "+annualSalary);
            System.Console.WriteLine("Annual take home salary: "+annualIncome);
        }
        else if(basicSalary<=20000 && basicSalary>10000)
        {
            double hra=0.25*basicSalary;
            double da=0.90*basicSalary;
            double monthlySalary=basicSalary+hra+da;
            double annualSalary=12*monthlySalary;
            double tax=0.06*annualSalary;
            double insurance=0.01*annualSalary;
            double annualIncome=(annualSalary-tax-insurance);
            System.Console.WriteLine("Annual Gross salary: "+annualSalary);
            System.Console.WriteLine("Annual take home salary: "+annualIncome);
        }
        else if(basicSalary>20000)
        {
            double hra=0.30*basicSalary;
            double da=0.95*basicSalary;
            double monthlySalary=basicSalary+hra+da;
            double annualSalary=12*monthlySalary;
            double tax=0.06*annualSalary;
            double insurance=0.01*annualSalary;
            double annualIncome=(annualSalary-tax-insurance);
            System.Console.WriteLine("Annual Gross salary: "+annualSalary);
            System.Console.WriteLine("Annual take home salary: "+annualIncome);
        }
        else
        {
            System.Console.WriteLine("Invalid input");
        }
    }
}
