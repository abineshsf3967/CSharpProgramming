using System;
namespace HierarchicalInheritance;
class Program
{
    public static void Main(string[] args)
    {
        //Application-1
        PersonalDetails person=new PersonalDetails("abinesh","palani",Gender.Male,6382600921);
        person.ShowDetails();
        
        //Applicaation-2
        StudentDetails student=new StudentDetails("666","abinesh","palani",Gender.Male,6382600921,Department.ECE,2018);
        student.ShowStudent();

        //Application-3
        CustomerDetails customer = new CustomerDetails("666","abinesh","palani",Gender.Male,6382600921,3000);
        customer.ShowCustomer();
    }
}
