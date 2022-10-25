using System;
namespace BankApplication
{
    public enum AccountType{Default,Male,Female,Transgender}
    public class SavingAccount:IDInfo,ICalculate,BankInfo
    {
        public int AccountNumber { get; set; }
        public AccountType AccountType { get; set; }



        public SavingAccount(string name,Gender gender,DateTime dob,long mobileNumber,string voterID,int aadharID,string panNumber,string bankName,string ifsc,string branch,int accountNumber,AccountType accountType):base(name,gender,dob,mobileNumber,voterID,aadharID,panNumber,bankName,ifsc,branch)
        {
            AccountNumber=accountNumber;
            AccountType=accountType;
        }

        public Display
    }
}