using System;
namespace BankApplication;
class Program
{
    public static void Main(string[] args)
    {
        SavingAccount account=new SavingAccount("Abinesh",Gender.Male,new DateTime(2000,11,12),6382600921,"cwpba23478",AccountType.Savings);
        account.ShowSaving();
        account.Deposit();
        account.WithDraw();
        account.BalanceCheck();
        System.Console.WriteLine();
        RecurringDeposit account1=new RecurringDeposit("Abinesh",Gender.Male,new DateTime(2000,11,12),6382600921,"cwpba23478",AccountType.RecurringDeposit);
        account1.ShowSaving();
        account1.Deposit();
        account1.WithDraw();
        account1.BalanceCheck();
    }
}