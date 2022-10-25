using System;
namespace StudentDetails;
class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo person=new PersonalInfo("abi","palanisamy",34567890,"abi@22",new DateTime(2022,11,13),Gender.Male);
        person.ShowPersonal();
        System.Console.WriteLine();
        StudentInfo student=new StudentInfo("abi","palanisamy",34567890,"abi@22",new DateTime(2022,11,13),Gender.Male,12,"Computer",2018);
        student.UpdateInfo();
        System.Console.WriteLine();
        HSCDetails mark=new HSCDetails("abi","palanisamy",34567890,"abi@22",new DateTime(2022,11,13),Gender.Male,12,"Computer",2018,98,97,89);
        mark.ShowHSC();
    }
}
