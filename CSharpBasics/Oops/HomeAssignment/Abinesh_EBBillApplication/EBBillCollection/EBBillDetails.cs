/// <summary>
/// Used to process the EBBill Collection open using this application
/// </summary>

namespace EBBillCollection
{
    /// <summary>
    /// CLass <see cref="EBBillDetails" /> used to collect customer details for the account open
    /// </summary>
    public class EBBillDetails
    {
        /// <summary>
        /// Static field is used to auto increment and it uniquely identify an instance of
        /// <see cref="EBBillDetails" /> class
        /// </summary>
        private static int s_meterID=1000;
        /// <summary>
        ///  Property MeterID used to uniquely identify a <see cref="EBBillDetails" /> class's object
        /// </summary>
        /// <value></value>
        public string MeterID { get; set; }
        /// <summary>
        /// Property UserName is used to provide name for a customer in object of <see  cref="EBBillDetails" /> class
        /// </summary>
        /// <value></value>
        public string UserName { get; set; }
        /// <summary>
        /// Property PhoneNumber is used to provide PhoneNumber for a customer in object of <see  cref="EBBillDetails" /> class
        /// </summary>
        /// <value></value>
        public long PhoneNumber { get; set; }
        /// <summary>
        /// Property MailID is used to provide MailID for a customer in object of <see  cref="EBBillDetails" /> class
        /// </summary>
        /// <value></value>
        public string MailID { get; set; }
        /// <summary>
        /// Property UnitUsed is used to provide UnitUsed for a customer in object of <see  cref="EBBillDetails" /> class
        /// </summary>
        /// <value></value>
        public int UnitUsed { get; set; }


        public EBBillDetails()
        {
            UserName="Your name";
            UnitUsed=0;
        }
        /// <summary>
        /// Constructor of <see cref="EBBillDetails" /> class used to initialize values to its properties
        /// </summary>
        /// <param name="userName"></param>Parameter UserName used to initialize a customer Name to Name property</param>
        /// <param name="phoneNumber"></param>Parameter phoneNumber used to initialize a phoneNumber to Name property</param>
        /// <param name="mailID"></param>Parameter mailID used to initialize a mailID to Name property</param>
        public EBBillDetails(string userName,long phoneNumber,string mailID)
        {
            s_meterID++;
            MeterID="SF"+s_meterID;
           UserName=userName;
           PhoneNumber=phoneNumber;
           MailID=mailID;   
        }
    }
}