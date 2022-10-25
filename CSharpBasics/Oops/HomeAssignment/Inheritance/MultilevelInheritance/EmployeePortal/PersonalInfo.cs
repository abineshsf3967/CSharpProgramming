using System;
namespace EmployeePortal
{
    public enum Gender{Default,Male,Female}
    public class PersonalInfo
    {
        public string EmployeeName { get; set; }
        public string FatherName { get; set; }
        public Gender EmployeeGender { get; set; }
        public long MobileNumber { get; set; }
        public DateTime DOB { get; set; }


        public PersonalInfo(string employeeName,string fatherName,Gender employeeGender,long mobileNumber,DateTime dob)
        {
            EmployeeName=employeeName;
            FatherName=fatherName;
            EmployeeGender=employeeGender;
            MobileNumber=mobileNumber;
            DOB=dob;
        }

        public void Display()
        {
            System.Console.WriteLine("Employee Name: "+EmployeeName);
            System.Console.WriteLine("FatherName: "+FatherName);
            System.Console.WriteLine("Employee Gender: "+EmployeeGender);
            System.Console.WriteLine("MobileNumber: "+MobileNumber);
            System.Console.WriteLine("DOB: "+DOB);
        }

    }
}