using System;
namespace PersonalDetails
{
    public class RegistrationPerson:PersonalInfo
    {
        private static int s_registrationNumber=100;
        public string RegistrationNumber { get; set; }
        public DateTime DateOfRegistration { get; set; }


        public RegistrationPerson(string name,string fatherName,string motherName,string address,int noOfSiblings,long phoneNumber,string mailID,DateTime dob,Gender personGender,Status marriedDetail,DateTime dateOfRegistration):base(name,fatherName,motherName,address,noOfSiblings,phoneNumber,mailID,dob,personGender,marriedDetail)
        {
            s_registrationNumber++;
            RegistrationNumber="RI"+s_registrationNumber;
            DateOfRegistration=dateOfRegistration;
        }


        public void ShowRegistration()
        {
            System.Console.WriteLine("RegistrationID: "+RegistrationNumber);
            ShowData();
            System.Console.WriteLine("DateOfRegistration: "+DateOfRegistration);

        }
    }
}