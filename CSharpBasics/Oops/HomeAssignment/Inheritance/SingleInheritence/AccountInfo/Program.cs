using System;
namespace AccountInfo;
class Program
{
    public static void Main(string[] args)
    {
        AccountInfo account=new AccountInfo("Abinesh","Palani",6382600921,"abinesh@22",new DateTime(2022,11,12),Gender.Male,"Mathura","k890ert",4000);
        account.ShowAccount();
    }
}