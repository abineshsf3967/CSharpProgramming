using System;
namespace CollegeAdministration
{
    public class TeacherInfo:PersonalInfo
    {
        private static int s_teacherID=100;
        public string TeacherID { get;  }
        public string SubjectTeaching { get; set; }
        public string Qualification { get; set; }
        public int YearOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; }



        public TeacherInfo(string name,string fatherName,long phoneNumber,string mailID,DateTime dob,Gender personGender,string subjectTeaching,string qualification,int yearOfExperience,DateTime dateOfJoining):base(name,fatherName,phoneNumber,mailID,dob,personGender)
        {
            s_teacherID++;
            TeacherID="TI"+s_teacherID;
            SubjectTeaching=subjectTeaching;
            Qualification=qualification;
            YearOfExperience=yearOfExperience;
            DateOfJoining=dateOfJoining;
        }

        public void ShowTeacher()
        {
            System.Console.WriteLine("TeacherID: "+TeacherID);
            ShowPersonal();
            System.Console.WriteLine("SubjectTeaching: "+SubjectTeaching);
            System.Console.WriteLine("Qualification: "+Qualification);
            System.Console.WriteLine("YearOfExperience: "+YearOfExperience);
            System.Console.WriteLine("DateOfJoining: "+DateOfJoining);
        }
    }

    
}