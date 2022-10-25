using System;
namespace StudentDetails
{
    public class HSCDetails:StudentInfo
    {
        private static int s_hscMarkSheetNumber=1001;
        public string HSCMarksheetNumber { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        public int Total { get; set; }
        public double PercentageMarks { get; set; }


        public HSCDetails(string name,string fatherName,long phoneNumber,string mailID,DateTime dob,Gender personGender,int standard,string branch,int academicYear,int physcis,int chemistry,int maths):base(name,fatherName,phoneNumber,mailID,dob,personGender,standard,branch,academicYear)
        {
            s_hscMarkSheetNumber++;
            HSCMarksheetNumber="HSC"+s_hscMarkSheetNumber;
            Physics=physcis;
            Chemistry=chemistry;
            Maths=maths;
            Total=(physcis+Chemistry+Maths);
            PercentageMarks=Total/3;
        }

        public void ShowHSC()
        {
            ShowPersonal();
            System.Console.WriteLine("Register Number: "+RegisterNumber);
            System.Console.WriteLine("Standard: "+Standard);
            System.Console.WriteLine("Branch: "+Branch);
            System.Console.WriteLine("Academic year: "+AcademicYear);
            System.Console.WriteLine("Physics: "+Physics);
            System.Console.WriteLine("Chemistry: "+Chemistry);
            System.Console.WriteLine("Maths: "+Maths);
            System.Console.WriteLine("Total: "+Total);
            System.Console.WriteLine("Percentage: "+PercentageMarks);

        }
    }
}