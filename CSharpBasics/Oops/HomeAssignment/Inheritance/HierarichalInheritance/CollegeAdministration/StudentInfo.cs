using System;
namespace CollegeAdministration;

    public class StudentInfo:PersonalInfo
    {
        private static int s_studentID=100;
        public string StudentID { get; set; }
        public string Degree { get; set; }
        public string Department { get; set; }
        public int Semester { get; set; }



        public StudentInfo(string name,string fatherName,long phoneNumber,string mailID,DateTime dob,Gender personGender,string degree,string department,int semester):base(name,fatherName,phoneNumber,mailID,dob,personGender)
        {
            s_studentID++;
            StudentID="SD"+s_studentID;
            Degree=degree;
            Department=department;
            Semester=semester;
        }

        public void ShowStudent()
        {
            System.Console.WriteLine("StudentID: "+StudentID);
            ShowPersonal();
            System.Console.WriteLine("Degree: "+Degree);
            System.Console.WriteLine("Deparment : "+Department);
            System.Console.WriteLine("Semester: "+Semester);
        }
    }
