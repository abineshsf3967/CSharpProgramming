using System;
namespace EmployeePortal
{
    public class EmployeeAttendance:PersonalInfo
    {
        public DateTime WorkedDate { get; set; }
        public int NumberOfHoursWorked { get; set; }




        public EmployeeAttendance(string employeeName,string fatherName,Gender employeeGender,long mobileNumber,DateTime dob,DateTime workedDate,int numberOfHoursWorked):base(employeeName,fatherName,employeeGender,mobileNumber,dob)
        {
            WorkedDate=workedDate;
            NumberOfHoursWorked=numberOfHoursWorked;
        }

        public void Attendance()
    {
        System.Console.WriteLine("WorkedDate: "+WorkedDate.ToString("dd/MM/yyyy"));
        System.Console.WriteLine("NumberOfHoursWorked: "+NumberOfHoursWorked);
    }
    }
    
}