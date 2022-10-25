using System;
namespace StudentMarkSheet
{
    public enum Gender{Default,Male,Female,Transgender}
    public class PersonalInfo
    {
        private static int s_registrationNumber=100;
        public string RegistrationNumber { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long PhoneNumber { get; set; }
        public DateTime DOB { get; set; }
        public Gender PersonGender { get; set; }


        public PersonalInfo(string name,string fatherName,long phoneNumber,DateTime dob,Gender personGender)
        {
            s_registrationNumber++;
            RegistrationNumber="RE"+s_registrationNumber;
            Name=name;
            FatherName=fatherName;
            PhoneNumber=phoneNumber;
            DOB=dob;
            PersonGender=personGender;
        }

        public void ShowPersonal()
        {
            System.Console.WriteLine("RegistrationNumber: "+RegistrationNumber);
            System.Console.WriteLine("Name: "+Name);
            System.Console.WriteLine("FtaherName: "+FatherName);
            System.Console.WriteLine("PnoneNumber: "+PhoneNumber);
            System.Console.WriteLine("DOB: "+DOB);
            System.Console.WriteLine("PersonGender: "+PersonGender);
        }        
    }
}