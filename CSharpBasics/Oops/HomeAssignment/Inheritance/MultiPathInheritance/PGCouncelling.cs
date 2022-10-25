using System;
namespace MultiPathInheritance
{
    public enum FeesStatus{Default,Paid,UnPaid}
    public class PGCouncelling:HSCInfo,UGInfo,PersonalInfo
    {
        private static int s_applicationID=2000;
        public string ApplicationID { get; set; }
        public DateTime DateOfApplication { get; set; }
        public FeesStatus FeesStatus  { get; set; }
        public long HSCMarkSheetNumber { get; set; }
        public int PhysicsMark { get; set; }
        public int ChemistryMark { get; set; }
        public int MathsMark { get; set; }
        public int TotalHSC { get; set; }
        public double PercentageHSC { get; set; }
        public long UGMarkSheetNumber { get; set; }
        public int SEM1 { get; set; }
        public int SEM2 { get; set; }
        public int SEM3 { get; set; }
        public int SEM4 { get; set; }
        public int TotalUG{ get; set; }
        public double PercentageUG { get; set; }
        public int AdharNumber { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long MobileNumber { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }



        public PGCouncelling(int adharNumber,string name,string fatherName,long mobileNumber,DateTime dob,Gender gender,DateTime dateOfApplication,FeesStatus feesStatus,int hscMarkSheetNumber,int physicsMark,int chemistryMark,int mathsMark,long ugMarkSheetNumber,int sem1,int sem2,int sem3,int sem4)
        {
            s_applicationID++;
            ApplicationID="AP"+s_applicationID;
            AdharNumber=adharNumber;
            Name=name;
            FatherName=fatherName;
            MobileNumber=mobileNumber;
            DOB=dob;
            Gender=gender;
            DateOfApplication=dateOfApplication;
            FeesStatus=feesStatus;
            HSCMarkSheetNumber=hscMarkSheetNumber;
            PhysicsMark=physicsMark;
            ChemistryMark=chemistryMark;
            MathsMark=mathsMark;
            UGMarkSheetNumber=ugMarkSheetNumber;
            SEM1=sem1;
            SEM2=sem2;
            SEM3=sem3;
            SEM4=sem4;
        }
        public void ShowInfo()
        {
            System.Console.WriteLine("ApplicationID: "+ApplicationID);
            System.Console.WriteLine("Date of Application: "+DateOfApplication.ToString("dd/MM/yyyy"));
            System.Console.WriteLine("Fees status: "+FeesStatus);
            System.Console.WriteLine("AdharNumber: "+AdharNumber);
            System.Console.WriteLine("Name: "+Name);
            System.Console.WriteLine("FatherName: "+FatherName);
            System.Console.WriteLine("Mobile Number: "+MobileNumber);
            System.Console.WriteLine("DOB: "+DOB.ToString("dd/MM/yyyy"));
            System.Console.WriteLine("Gender: "+Gender);
        }



        public void ShowHSCMarkSheet()
        {
            System.Console.WriteLine("HSC MarkSheetNumber: "+HSCMarkSheetNumber);
            System.Console.WriteLine("Physcis Mark: "+PhysicsMark);
            System.Console.WriteLine("Chemistry Mark: "+ChemistryMark);
            System.Console.WriteLine("Maths Mark: "+MathsMark);
            CalculateHSC();
        }
         public void CalculateHSC()
         {
            TotalHSC=PhysicsMark+ChemistryMark+MathsMark;
            PercentageHSC=TotalHSC/3;
            System.Console.WriteLine("Total: "+TotalHSC);
            System.Console.WriteLine("Percentage: "+PercentageHSC);
         }

         public void ShowUGMarkSheet()
         {
            System.Console.WriteLine("UG MarkSheetNumber: "+UGMarkSheetNumber);
            System.Console.WriteLine("SEM 1: "+SEM1);
            System.Console.WriteLine("SEM 2: "+SEM2);
            System.Console.WriteLine("SEM 3: "+SEM3);
            System.Console.WriteLine("SEM 4: "+SEM4);
            CalculateUG();
         }

         public void CalculateUG()
         {
            TotalUG=SEM1+SEM2+SEM3+SEM4;
            PercentageUG=TotalUG/4;
            System.Console.WriteLine("Total: "+TotalUG);
            System.Console.WriteLine("Percentage: "+PercentageUG);
         }



    }
}