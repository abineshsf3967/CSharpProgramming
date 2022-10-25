using System;
namespace AccountInfo
{
    public class AccountInfo:PersonalInfo
    {
      private static int s_accountNumber=100;  
      public string AccountNumber  { get;  }
      public string BranchName { get; set; } 
      public string IFSCCode { get; set; }
      public double Balance { get; set; }

      public AccountInfo(string name,string fatherName,long phoneNumber,string mailID,DateTime dob,Gender personGender,string branch,string ifscCode,double balance):base(name,fatherName,phoneNumber,mailID,dob,personGender)
      {
        s_accountNumber++;
        AccountNumber="AC"+s_accountNumber;
        BranchName=branch;
        IFSCCode=ifscCode;
        Balance=balance;
      }  

      public void ShowAccount()
      {
        System.Console.WriteLine("AccountNumber: "+AccountNumber);
        ShowPersonal();
        System.Console.WriteLine("BranchName: "+BranchName);
        System.Console.WriteLine("IFSCCode: "+IFSCCode);
        System.Console.WriteLine("Balance: "+Balance);
      }
    }
}