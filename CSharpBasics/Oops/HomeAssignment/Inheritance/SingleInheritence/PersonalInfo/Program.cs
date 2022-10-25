using System;
namespace PersonalInfo;
class Program
{
    public static void Main(string[] args)
    {
        StudentInfo student=new StudentInfo("Abinesh","Palani",6382600921,"abinesh@22",new DateTime(2022,11,12),Gender.Male,12,"ComputerScience",2018);
        student.UpdateInfo();
    }
}
