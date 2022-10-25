using System;
namespace CollegeAdministration;
class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo person =new PersonalInfo("Abinesh","Palani",98765432345,"abi@23",new DateTime(2022,10,13),Gender.Male);
        person.ShowPersonal();
        TeacherInfo teacher=new TeacherInfo("Abinesh","palani",098765434567,"abi@22",new DateTime(2022,11,21),Gender.Male,"computer","BE",12,new DateTime(2022,11,13));
        teacher.ShowTeacher();
        StudentInfo student=new StudentInfo("Abinesh","palani",098765434567,"abi@22",new DateTime(2022,11,21),Gender.Male,"BE","CSE",8);
        student.ShowStudent();
        PrincipalInfo principal= new("Abinesh","palani",098765434567,"abi@22",new DateTime(2022,11,21),Gender.Male,"BE",12,new DateTime(2022,10/11));
        principal.ShowPrincipal();

    }
}