namespace CafeteriaApplication
{
    public interface IBalance
    {
     
      public double WalletBalance { get; set; } 
      void WalletRecharge(UserDetails user,double amount);   
    }
}