using System;
/// <summary>
/// Used to process the Bank Account open using this application
/// </summary>
namespace Library
{
    /// <summary>
    /// Used to choose the student gender information
    /// </summary>
    public enum Gender{Default,Male,Female,Transgender}
    /// <summary>
    /// CLass <see cref="BankDetails" /> used to collect customer details for the account open
    /// </summary>
    public class BankDetails
    {
        /// <summary>
        /// Static field is used to auto increment and it uniquely identify an instance of
        /// <see cref="BankDetails" /> class
        /// </summary>
        private static int s_customerID =1001;
        /// <summary>
        /// Property CustomerID used to uniquely identify a <see cref="BankDetails" /> class's object
        /// </summary>
        /// <value></value>
        public string CustomerID { get; set; }
        /// <summary>
        /// Property CustomerName is used to provide name for a customer in object of <see  cref="BankDetails" /> class
        /// </summary>
        /// <value></value>
        
        public string CustomerName { get; set; }
        /// <summary>
        /// Property MailID is used to provide MailID for a customer in object of <see  cref="BankDetails" /> class
        /// </summary>
        /// <value></value>
        public string MailID { get; set; }
        /// <summary>
        /// property Gender is used to provide gender for a customer in object of <see  cref="BankDetails" /> class
        /// </summary>
        /// <value></value>
        public Gender Gender { get; set; }
        /// <summary>
        /// Property MobileNumber is used to provide mobilenumber for a customer in object of <see  cref="BankDetails" /> class
        /// </summary>
        /// <value></value>
        public long MobileNumber { get; set; }
        /// <summary>
        /// Property DOB is used to provide dob for a customer in object of <see  cref="BankDetails" /> class
        /// </summary>
        /// <value></value>
        public DateTime DOB { get; set; }
       
        /// <summary>
        /// Property Balance is used to provide balance for a customer account in object of <see  cref="BankDetails" /> class
        /// </summary>
        /// <value></value>
        
        
        public double Balance  { get; set; }
        

        public BankDetails()
        {
             CustomerName="Your name";
             Balance=0;
        }
        /// <summary>
        /// Constructor of <see cref="BankDetails" /> class used to initialize values to its properties
        /// </summary>
        /// <param name="customerName"></param>Parameter CustomerName used to initialize a customer Name to Name property</param>
        /// <param name="gender"></param>Parameter Gender used to initialize a customer gender to Name property</param>
        /// <param name="mobileNumber"></param>Parameter MobileNumber used to initialize a mobilenumber to Name property</param>
        /// <param name="mailID"></param>Parameter MailID used to initialize a mailID to Name property</param>
        /// <param name="dob"></param>Parameter dob used to initialize a dob to Name property</param>
        public BankDetails(string customerName,Gender gender,long mobileNumber,string mailID,DateTime dob)
        {
             s_customerID++;
             CustomerID= "HDFC"+ s_customerID;
            CustomerName = customerName;
            Gender = gender;
            MobileNumber=mobileNumber;
            MailID=mailID;
            DOB=dob;
            
        }
        
    }
}