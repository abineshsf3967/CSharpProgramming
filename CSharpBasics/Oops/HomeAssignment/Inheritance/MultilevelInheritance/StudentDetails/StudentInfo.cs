using System;
namespace StudentDetails
{
    public class StudentInfo:PersonalInfo
    {
         private static int s_registerNumber=100;
        public string RegisterNumber { get; set; }
        public int Standard { get; set; }
        public string Branch { get; set; }
        public int AcademicYear { get; set; }


        public StudentInfo(string name,string fatherName,long phoneNumber,string mailID,DateTime dob,Gender personGender,int standard,string branch,int academicYear):base(name,fatherName,phoneNumber,mailID,dob,personGender)
        {
            s_registerNumber++;
            RegisterNumber="RI"+ s_registerNumber;
            Standard=standard;
            Branch=branch;
            AcademicYear=academicYear;
        }

       

        public void UpdateInfo()
        {
            System.Console.WriteLine("Register Number: "+RegisterNumber);
            ShowPersonal();
            System.Console.WriteLine("Standard: "+Standard);
            System.Console.WriteLine("Branch: "+Branch);
            System.Console.WriteLine("Academic year: "+AcademicYear);
        }


        public StudentInfo(string registerNumber,string name,string fatherName,long phoneNumber,string mailID,DateTime dob,Gender personGender,int standard,string branch,int academicYear):base(name,fatherName,phoneNumber,mailID,dob,personGender)
        {
            RegisterNumber=registerNumber;
            Standard=standard;
            Branch=branch;
            AcademicYear=academicYear;
        }

        public void UpdateInformation()
        {
            System.Console.WriteLine("Register Number: "+RegisterNumber);
            ShowPersonal();
            System.Console.WriteLine("Standard: "+Standard);
            System.Console.WriteLine("Branch: "+Branch);
            System.Console.WriteLine("Academic year: "+AcademicYear);
        }
    }
}