namespace CafeteriaApplication
{
    public class UserDetails:PersonalDetails,IBalance
    {
        /// <summary>
        /// Unique ID given for the user
        /// </summary>
        private static int s_userID=1000;
        /// <summary>
        /// Property UserID is uded to get the userID in the instance of class
        /// </summary>
        /// <value></value>
        public string UserID { get; }
        /// <summary>
        /// Property WorkStationNumber is used to provide the WorkStationNumber in the instance of class
        /// </summary>
        /// <value></value>
        public string WorkStationNumber { get; set; }
        /// <summary>
        /// Property WalletBalance is uded to get the WalletBalance in the instance of class
        /// </summary>
        /// <value></value>
        public double WalletBalance { get; set; }
        public UserDetails()
        {

        }
        /// <summary>
        /// Constructor used to initialize the value for property
        /// </summary>
        /// <param name="name"></param>name is used to initialize the Name property
        /// <param name="fatherName"></param>fatherName is used to initialize the FatherName property
        /// <param name="gender"></param>gender is used to initialize the Gender property
        /// <param name="mobileNumber"></param>mobileNumber is used to initialize the MobileNumber property
        /// <param name="mailID"></param>mailID is used to initialize the MailID property
        /// <param name="workStation"></param>workStation is used to initialize the WorkStation property
        /// <param name="walletBalance"></param>walletBalance is used to initialize the WalletBalance property
        /// <returns></returns>
        public UserDetails(string name,string fatherName,Gender gender,string mobileNumber,string mailID,string workStation,double walletBalance):base(name,fatherName,gender,mobileNumber,mailID)
        {
            s_userID++;
            UserID="SF"+s_userID;
            WorkStationNumber=workStation;
            WalletBalance=walletBalance;
        }
        /// <summary>
        /// Constructor is used for ReadFile in list
        /// </summary>
        /// <param name="data"></param>
        public UserDetails(string data)
        {
            string[] values=data.Split(',');
            s_userID=int.Parse(values[0].Remove(0,2));
            UserID=values[0];
            Name=values[1];
            FatherName=values[2];
            Gender=Gender.Parse<Gender>(values[3],true);
            MobileNumber=values[4];
            MailID=values[5];
            WorkStationNumber=values[6];
            WalletBalance=double.Parse(values[7]);
        }
        /// <summary>
        /// Method used to recharge the walletBalance of particular user
        /// </summary>
        /// <param name="user"></param>user specifies the particular registered user
        /// <param name="balance"></param>Balance is recharge amount entered amount in calling method
        public void WalletRecharge(UserDetails user,double balance)
        {
            WalletBalance+=balance;
        }
    }
}