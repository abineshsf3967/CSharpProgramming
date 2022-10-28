namespace BlackTicket
{
    /// <summary>
    /// The class is refer to userDetails 
    /// It inherit the class PersonalDetails and interface Iwallet
    /// </summary>
    public class UserDetails:PersonalDetails,IWallet
    {
        private static int s_userID=1000;
        /// <summary>
        /// Used to assign unique ID for the user
        /// </summary>
        /// <value></value>
        public string UserID { get; }
        /// <summary>
        /// Use to store the wallet Balance for the user
        /// </summary>
        /// <value></value>
        public double WalletBalance { get; set; }
        public UserDetails()
        {
            
        }
        /// <summary>
        /// Constructor used to initialize the value for property 
        /// </summary>
        /// <param name="name"></param>Name property is used to store the name of the user
        /// <param name="age"></param>Age property is used to stroe the age of user
        /// <param name="mobileNumber"></param>MobileNumber property is used to store the mobileNumber of user
        /// <param name="walletBalance"></param>WalletBalance property is used to to store the walletBalance
        /// <returns></returns>
        public UserDetails(string name,int age,string mobileNumber,double walletBalance):base(name,age,mobileNumber)
        {
            s_userID++;
            UserID="UID"+s_userID;
            WalletBalance=walletBalance;
        }
        /// <summary>
        /// Constructor is used for ReadFile in list
        /// </summary>
        /// <param name="data"></param>
        public UserDetails(string data)
        {
            string[] values=data.Split(',');
            s_userID=int.Parse(values[0].Remove(0,3));
            UserID=values[0];
            Name=values[1];
            Age=int.Parse(values[2]);
            MobileNumber=values[3];
            WalletBalance=double.Parse(values[4]);
        }

        public void RechargeWallet(UserDetails user,double amount)
        {
            WalletBalance+=amount;
        }

    }
}