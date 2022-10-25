namespace Question2
{
    public class SyncFusion:FreeLancer
    {
        private static int s_employeeID=1000;
        public string EmployeeID { get; set; }
        public string WorkLocation { get; set; }
        public double Salary { get; set; }

        public SyncFusion(string name,string fatherName,Gender gender,string qualification,string role,int noOfWorkingDays,string workLocation):base(name,fatherName,gender,qualification,role,noOfWorkingDays)
        {
            s_employeeID++;
            EmployeeID="SF"+s_employeeID;
            WorkLocation=workLocation;
        }

        public override void CalculateSalary()
        {
            Salary=NoOfWorkingDays*500;
        }

        public override void Display()
        {
            System.Console.WriteLine("EmployeeID: "+EmployeeID);
            System.Console.WriteLine("Name: "+Name);
            System.Console.WriteLine("FatherName: "+FatherName);
            System.Console.WriteLine("Gender: "+Gender);
            System.Console.WriteLine("Qualification: "+Qualification);
            System.Console.WriteLine("Role: "+Role);
            System.Console.WriteLine("WorkLocation: "+WorkLocation);
            System.Console.WriteLine("NoOfWorkingDays: "+NoOfWorkingDays);
            System.Console.WriteLine("SalaryAmount: "+Salary);
        }
    }
}