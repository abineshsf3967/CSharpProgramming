using System;
namespace SingleInheritance;
class Program
{
    public static void Main(string[] args)
    {

        StudentDetails student=new StudentDetails("666","abinesh","palani",Gender.Male,6382600921,Department.ECE,2018);
        student.ShowStudent();
    }
}
