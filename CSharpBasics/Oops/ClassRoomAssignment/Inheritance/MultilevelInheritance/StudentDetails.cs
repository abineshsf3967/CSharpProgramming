namespace MultilevelInheritance
{
    public enum Department{Default,EEE,ECE,CSE}
    public class StudentDetails:PersonalDetails
    {
        private static int s_studentID=1000;
        public string StudentID { get;  }
        public Department Department { get; set; }
        public int Year { get; set; }

        public StudentDetails(string aid,string name,string fatherName,Gender gender,long phoneNumber,Department department,int year):base(aid,name,fatherName,gender,phoneNumber)
        {
            s_studentID++;
            StudentID="SID"+s_studentID;
            Department=department;
            Year=year;
        }

        public void ShowStudent()
        {
            System.Console.WriteLine("StudentID: "+StudentID);
            ShowDetails();
            System.Console.WriteLine("Department: "+Department);
            System.Console.WriteLine("Year: "+Year);
        }
        public StudentDetails(string studentID,string aid,string name,string fatherName,Gender gender,long phoneNumber,Department department):base(aid,name,fatherName,gender,phoneNumber)
        {
            StudentID=studentID;
             Department=department;

        }
    }
}