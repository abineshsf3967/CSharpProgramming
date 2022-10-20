namespace EcommerseApplication
{
    public class CustomerDetails
    {
        private static int s_customerID=1000;
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string City { get; set; }
        public long MobileNumber { get; set; }
        public double WalletBalance { get; set; }
        public string MailID { get; set; }



        public CustomerDetails(string customerName,string city,long mobileNumber,double walletBalance,string mailID)
        {
            s_customerID++;
            CustomerID="CID"+s_customerID;
            CustomerName=customerName;
            City=city;
            MobileNumber=mobileNumber;
            WalletBalance=walletBalance;
            MailID=mailID;
        }
    }
}