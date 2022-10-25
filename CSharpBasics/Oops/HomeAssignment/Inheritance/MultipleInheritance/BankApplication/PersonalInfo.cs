using System;
namespace BankApplication
{
    public enum Gender{Default,Male,Female,Transgender}
    public class PersonalInfo
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }
        public long MobileNumber { get; set; }
        public string PANNumber { get; set; }

        public PersonalInfo(string name,Gender gender,DateTime dob,long mobileNumber,string panNumber)
        {
            Name=name;
            Gender=gender;
            DOB=dob;
            MobileNumber=mobileNumber;
            PANNumber=panNumber;
        }


        public void ShowDetails()
        {
            System.Console.WriteLine("HolderName: "+Name);
            System.Console.WriteLine("Gender: "+Gender);
            System.Console.WriteLine("DOB: "+DOB.ToString("dd/MM/yyyy"));
            System.Console.WriteLine("MobileNumber: "+MobileNumber);
            System.Console.WriteLine("PAN number: "+PANNumber);
        }
    }
}