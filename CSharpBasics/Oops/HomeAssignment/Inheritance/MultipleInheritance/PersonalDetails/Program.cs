using System;
namespace PersonalDetails;
class Program
{
    public static void Main(string[] args)
    {
        RegistrationPerson person=new RegistrationPerson("abi","palani","chellammal","salem",1,98765432,"abi@22",new DateTime(2000,11,12),Gender.Male,Status.Single,DateTime.Now);
        person.ShowRegistration();
    }
}
