using System;
namespace EmployeeSalary
{
    public class TemporaryEmployee:SalaryInfo
    {
        private static int s_tempEmployeeID=200;
        public string TempEmployeeID { get; set; }
        public string TempEmployeeType { get; set; }




        public TemporaryEmployee(double basicSalary,int month,string tempEmployeeType):base(basicSalary,month)
        {
            s_tempEmployeeID++;
            TempEmployeeID="TE"+s_tempEmployeeID;
            TempEmployeeType=tempEmployeeType;
        }

        public void TempDisplay()
        {
          double totalSalary=(BasicSalary+0.002+0.0018-0.001)*Month;
          System.Console.WriteLine("Total Salary: "+Math.Round(totalSalary,2));
        }


        public void TempSalary()
        {
            System.Console.WriteLine("EmployeeID: "+TempEmployeeID);
            System.Console.WriteLine("EmployeeType: "+TempEmployeeType);
            Display();
            TempDisplay();
        }
    }
}