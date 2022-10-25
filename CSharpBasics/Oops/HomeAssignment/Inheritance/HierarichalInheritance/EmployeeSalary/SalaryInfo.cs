namespace EmployeeSalary
{
    public class SalaryInfo
    {
        public double BasicSalary { get; set; }
        public int Month { get; set; }


        public SalaryInfo(double basicSalary,int month)
        {
            BasicSalary=basicSalary;
            Month=month;
        }

        public void Display()
        {
            System.Console.WriteLine("Basic Salary: "+BasicSalary);
            System.Console.WriteLine("Month: "+Month);
        }
    }
}