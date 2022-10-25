
using System;
namespace CollegeAdministration
{
    public class PrincipalInfo:PersonalInfo
    {
        private static int s_principaID=1001;
        public string PrincipalID { get; set; }
        public string Qualification { get; set; }
        public int YearOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; }


        public PrincipalInfo(string name,string fatherName,long phoneNumber,string mailID,DateTime dob,Gender personGender,string qualification,int yearOfExperience,DateTime dateOfJoining):base(name,fatherName,phoneNumber,mailID,dob,personGender)
        {
            s_principaID++;
            PrincipalID="PI"+s_principaID;
            Qualification=qualification;
            YearOfExperience=yearOfExperience;
            DateOfJoining=dateOfJoining;
        }

        public void ShowPrincipal()
        {
            System.Console.WriteLine("PrincipalID: "+PrincipalID);
            ShowPersonal();
            System.Console.WriteLine("Qualification: "+Qualification);
            System.Console.WriteLine("Years of experience: "+YearOfExperience);
            System.Console.WriteLine("Date of joining: "+DateOfJoining);
        }
    }
}