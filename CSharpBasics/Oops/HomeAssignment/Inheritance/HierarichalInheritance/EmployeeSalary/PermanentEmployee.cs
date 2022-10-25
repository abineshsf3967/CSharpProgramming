using System;
namespace EmployeeSalary
{
    public class PermanentEmployee:SalaryInfo
    {
        private static int s_employeeID=100;
        public string EmployeeID { get; set; }
        public string EmployeeType { get; set; }


        public PermanentEmployee(double basicSalary,int month,string employeeType):base(basicSalary,month)
        {
            s_employeeID++;
            EmployeeID="EP"+s_employeeID;
            EmployeeType=employeeType;
        }

       public void TotalSalary()
       {
          double totalSalary=(BasicSalary+0.002+0.0018-0.001)*Month;
          System.Console.WriteLine("Total Salary: "+Math.Round(totalSalary,2));
       }

       public void ShowSalary()
       {
           System.Console.WriteLine("EmployeeID: "+EmployeeID);
            System.Console.WriteLine("EmployeeType: "+EmployeeType);
            Display();
          TotalSalary();
       }
    }
}