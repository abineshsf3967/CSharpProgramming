using System;
namespace MultilevelInheritance
{
    public class EmploymentDetails:StudentDetails
    {
        private static int s_employmentID=1000;
        public string EmploymentID { get; }
        public DateTime RegistrationDate { get; set; }


        public EmploymentDetails(string studentID,string aid,string name,string fatherName,Gender gender,long phoneNumber,Department department,DateTime registrationDate):base(studentID,aid,name,fatherName,gender,phoneNumber,department)
        {
            s_employmentID++;
            EmploymentID="EID"+s_employmentID;
            RegistrationDate=registrationDate;
        }
        public void ShowEmployment()
        {
            System.Console.WriteLine("EmploymentID: "+EmploymentID);
            System.Console.WriteLine("StudentID: "+StudentID);
            ShowDetails();
            System.Console.WriteLine("Department: "+Department);
            System.Console.WriteLine("RegistrationDate: "+RegistrationDate.ToString("dd/MM/yyyy"));

        }
    }
}