namespace BlackTicket
{
    public interface IWallet
    {
         double WalletBalance { get; set; }
         void RechargeWallet(UserDetails user,double amount);
    }
}