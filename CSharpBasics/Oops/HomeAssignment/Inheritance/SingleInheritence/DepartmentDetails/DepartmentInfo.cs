namespace DepartmentDetails
{
    public class DepartmentInfo
    {
        public string DepartmentName { get; set; }
        public string Degree { get; set; }

        public DepartmentInfo(string departmentName,string degree)
        {
            DepartmentName=departmentName;
            Degree=degree;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine("DepartmentName: "+DepartmentName);
            System.Console.WriteLine("Degree: "+Degree);
        }
    }
}