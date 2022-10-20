namespace MultipleInheritance
{
    public enum Department{Default,EEE,ECE,CSE}
    public class StudentDetails:PersonalDetails,IMarkDetails
    {
        private static int s_studentID=1000;
        public string StudentID { get;  }
        public Department Department { get; set; }
        public int Year { get; set; }
        public int Physics { get; set; }
        public  int Chemistry { get; set; }
        public int Maths { get; set; }
        public int Total { get; set; }
        public double Average { get; set; }
        

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

        public void GetMark(int physics,int chemistry,int maths)
        {
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }
        public void Calculate()
        {
            Total=(Physics+Chemistry+Maths);
            Average=Total/3;
        }
        public void ShowMark()
        {
            System.Console.WriteLine("Physics: "+Physics);
            System.Console.WriteLine("Chemistry:"+Chemistry);
            System.Console.WriteLine("Maths: "+Maths);
            System.Console.WriteLine("Total: "+Total);
            System.Console.WriteLine("Average: "+Average);
        }
    }
}