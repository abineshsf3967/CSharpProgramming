using System;
namespace BankApplication
{
    public enum Gender{Default,Male,Female}
    public class PersonalInfo
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }
        public long MobileNumber { get; set; }



        public PersonalInfo(string name,Gender gender,DateTime dob,long mobileNumber)
        {
            Name=name;
            Gender=gender;
            DOB=dob;
            MobileNumber=mobileNumber;
        }

        

    }
}