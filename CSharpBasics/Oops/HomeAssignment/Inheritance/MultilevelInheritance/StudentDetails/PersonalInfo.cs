using System;
namespace StudentDetails
{
    public enum Gender{Default,Male,Female,Transgender}
    public class PersonalInfo
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long PhoneNumber { get; set; }
        public string MailID { get; set; }
        public DateTime DOB { get; set; }
        public Gender PersonGender { get; set; }


        public PersonalInfo(string name,string fatherName,long phoneNumber,string mailID,DateTime dob,Gender personGender)
        {
            Name=name;
            FatherName=fatherName;
            PhoneNumber=phoneNumber;
            MailID=mailID;
            DOB=dob;
            PersonGender=personGender;
        }

        public void ShowPersonal()
        {
            System.Console.WriteLine("Name: "+Name);
            System.Console.WriteLine("FtaherName: "+FatherName);
            System.Console.WriteLine("PnoneNumber: "+PhoneNumber);
            System.Console.WriteLine("MilID: "+MailID);
            System.Console.WriteLine("DOB: "+DOB);
            System.Console.WriteLine("PersonGender: "+PersonGender);
        }      
    }
}