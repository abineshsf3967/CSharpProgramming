using System;
namespace MultiPathInheritance;
class Program
{
    public static void Main(string[] args)
    {
        PGCouncelling member1=new PGCouncelling(4567890,"Abinesh","Palanisamy",556789,new DateTime(2000,11,12),Gender.Male,DateTime.Now,FeesStatus.Paid,2345678,98,97,96,3456789,98,78,56,89);
        member1.ShowInfo();
        member1.ShowHSCMarkSheet();
        member1.ShowUGMarkSheet();
    }
}