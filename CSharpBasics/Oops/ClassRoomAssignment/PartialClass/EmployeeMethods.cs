namespace PartialClass
{
    public partial class EmployeeProps
    {
        public EmployeeProps(int id,string name)
        {
            this.EmpID=id;
            this.Name=name;
        }

        public void DisplayEmpInfo()
        {
            System.Console.WriteLine("EmpID: "+EmpID+" "+"Employee Name: "+Name);
        }
    }
}