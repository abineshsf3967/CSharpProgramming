/// <summary>
/// namespace is declared as OnlineMedical Store
/// UserDetails class include in the namespace
/// </summary>
namespace OnlineMedicalStore
{
    /// <summary>
    /// UserDetails class contains propety of user
    /// </summary>
    public class UserDetails
    {
        /// <summary>
        /// It is a unique ID given for the registered user
        /// </summary>
        private static int s_userID=1000;
        /// <summary>
        /// It is a unique userID which displayed to the user
        /// </summary>
        /// <value></value>
        public string UserID { get;  }
        /// <summary>
        /// Name of user who registered
        /// </summary>
        /// <value></value>
        public string UserName { get; set; }
        /// <summary>
        /// Age represent the age of the individual user
        /// </summary>
        /// <value></value>
        public int Age { get; set; }
        /// <summary>
        /// it denote the user location
        /// </summary>
        /// <value></value>
        public string City { get; set; }
        /// <summary>
        /// PhoneNumber represent the phoneNumber of the individual user
        /// </summary>
        /// <value></value>
        public long PhoneNumber { get; set; }
        /// <summary>
        /// it denotes the balance available to user
        /// </summary>
        /// <value></value>
        public double Balance { get; set; }

        /// <summary>
        /// Constructor named as UserDetails ref>="UserDetails class"
        /// </summary>
        /// <param name="userName"></param>userName is assigned to the property UserName 
        /// <param name="age"></param>Age is ssigned to the property Age
        /// <param name="city"></param>city is assigned to the property City
        /// <param name="phoneNumber"></param>phoneNumber is assigned to the property PhoneNumber
        /// <param name="balance"></param>Balance is assigned to the property Balance
        public UserDetails(string userName,int age,string city,long phoneNumber,double balance)
        {
            s_userID++;
            UserID="UID"+s_userID;
            UserName=userName;
            Age=age;
            City=city;
            PhoneNumber=phoneNumber;
            Balance=balance;
        }  
    }
}