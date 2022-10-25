namespace LibraryInfo
{
    public class DepartmentDetails
    {
        public string DepartmentName { get; set; }
        public string Degree { get; set; }


        public DepartmentDetails(string departmentName,string degree)
        {
            DepartmentName=departmentName;
            Degree=degree;
        }


        public void ShowDetails()
        {
            System.Console.WriteLine("Department name: "+DepartmentName);
            System.Console.WriteLine("Degree: "+Degree);
        }
    }
}