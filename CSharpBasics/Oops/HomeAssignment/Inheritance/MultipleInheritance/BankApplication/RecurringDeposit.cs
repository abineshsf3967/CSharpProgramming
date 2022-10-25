using System;
namespace BankApplication
{
    
    public class RecurringDeposit:PersonalInfo,Calculate
    {
        private static int s_accountNumber=200;
        public string AccountNumber { get; set; }
        public AccountType AccountType  { get; set; }
        public double Balance { get; set; }

          public RecurringDeposit(string name,Gender gender,DateTime dob,long mobileNumber,string panNumber,AccountType accountType):base(name,gender,dob,mobileNumber,panNumber)
        {
            s_accountNumber++;
            AccountNumber="SA"+s_accountNumber;
            AccountType=accountType;
        }

        public void ShowSaving()
        {
            System.Console.WriteLine("AccountNumber: "+AccountNumber);
            System.Console.WriteLine("AccountType: "+AccountType);
            ShowDetails();

        }

        public void Deposit()
        {
            System.Console.WriteLine("Enter the deposit Amount: ");
            double amount=double.Parse(Console.ReadLine());
            Balance+=amount;
            System.Console.WriteLine("Balance After deposit: "+Balance);
        }

        public void WithDraw()
        {
            System.Console.WriteLine("Enter the Amount to withdraw: ");
            double amount=double.Parse(Console.ReadLine());
            Balance-=amount;
            System.Console.WriteLine("Balance after withdraw: "+Balance);
        }

        public void BalanceCheck()
        {
            System.Console.WriteLine("Balance: "+Balance);
        }

    }
}