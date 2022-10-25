using System;
namespace EmployeePortal
{
    public class SalaryInfo:EmployeeAttendance
    {
        public double SalaryOfTheMonth { get; set; }
        public int Month { get; set; }


        public SalaryInfo(string employeeName,string fatherName,Gender employeeGender,long mobileNumber,DateTime dob,DateTime workedDate,int numberOfHoursWorked,double salaryOfTheMonth,int month):base(employeeName,fatherName,employeeGender,mobileNumber,dob,workedDate,numberOfHoursWorked)
        {
            SalaryOfTheMonth=salaryOfTheMonth;
            Month=month;
        }

        public void Salary()
        {
            Display();
            Attendance();
            System.Console.WriteLine("SalaryOfTheMonth: "+SalaryOfTheMonth);
            System.Console.WriteLine("Month: "+Month);
        }
    }
}