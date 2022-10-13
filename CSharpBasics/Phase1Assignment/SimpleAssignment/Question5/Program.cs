using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        int  basicSalary=10000;
        float da=(10/100)*basicSalary;
        float hra=(10/100)*basicSalary;
        double monthlySalary=basicSalary+da+hra;
        double annualSalary=12*monthlySalary;
        double taxReduction=(5/100)*annualSalary;
        double annualIncome=annualSalary-taxReduction;
        System.Console.WriteLine("Annual Income: "+annualIncome);
        
    }
}