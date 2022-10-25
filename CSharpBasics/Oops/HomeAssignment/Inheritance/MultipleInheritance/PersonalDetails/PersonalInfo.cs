using System;
namespace PersonalDetails
{
    public enum Gender{Default,Male,Female,Transgender}
    public enum Status{Default,Married,Single}
    public class PersonalInfo:IShowData
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Address { get; set; }
        public int NoOfSiblings { get; set; }
        public long PhoneNumber { get; set; }
        public string MailID { get; set; }
        public DateTime DOB { get; set; }
        public Gender PersonGender { get; set; }
        public Status MarriedDetails { get; set; }


        public PersonalInfo(string name,string fatherName,string motherName,string address,int noOfSiblings,long phoneNumber,string mailID,DateTime dob,Gender personGender,Status mmarriedDetails)
        {
            Name=name;
            FatherName=fatherName;
            MotherName=motherName;
            Address=address;
            NoOfSiblings=noOfSiblings;
            PhoneNumber=phoneNumber;
            MailID=mailID;
            DOB=dob;
            PersonGender=personGender;
            MarriedDetails=mmarriedDetails;
        }

        public void ShowData()
        {
            System.Console.WriteLine("Name: "+Name);
            System.Console.WriteLine("FatherName: "+FatherName);
            System.Console.WriteLine("MotherName: "+MotherName);
            System.Console.WriteLine("Address: "+Address);
            System.Console.WriteLine("NoOfSiblings: "+NoOfSiblings);
            System.Console.WriteLine("PnoneNumber: "+PhoneNumber);
            System.Console.WriteLine("MilID: "+MailID);
            System.Console.WriteLine("DOB: "+DOB);
            System.Console.WriteLine("PersonGender: "+PersonGender);
            System.Console.WriteLine("Mrried Status: "+MarriedDetails);
        }   
    }
}