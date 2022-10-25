using System;
namespace JobApplication
{
    public enum Gender{Default,Male,Female}
    public class PersonalInfo:IFamilyInfo
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }
        public long MobileNumber { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public  string PermanentAddress { get; set; }



        public PersonalInfo(string name,Gender gender,DateTime dob,long mobileNumber,string fatherName,string motherName,string permanentAddress)
        {
            Name=name;
            Gender=gender;
            DOB=dob;
            MobileNumber=mobileNumber;
            FatherName=fatherName;
            MotherName=motherName;
            PermanentAddress=permanentAddress;
        }
    }
}

