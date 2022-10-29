namespace CafeteriaApplication
{
    public enum Gender{Default,Male,Female,Transgender}
    public class PersonalDetails
    {
        /// <summary>
        ///  Property Name is used to provide the Name in the instance of class
        /// </summary>
        /// <value></value>
        public string Name { get; set; }
        /// <summary>
        ///  Property FatherName is used to provide the FatherName in the instance of class
        /// </summary>
        /// <value></value>
        public string FatherName { get; set; }
        /// <summary>
        ///  Property Gender is used to provide the Gender in the instance of class
        /// </summary>
        /// <value></value>
        public Gender Gender { get; set; }
        /// <summary>
        ///  Property MobileNumber is used to provide the MobileNumber in the instance of class
        /// </summary>
        /// <value></value>
        public string MobileNumber { get; set; }
        /// <summary>
        ///  Property MailID is used to provide the MailID in the instance of class
        /// </summary>
        /// <value></value>
        public string MailID { get; set; }
        public PersonalDetails()
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
        public PersonalDetails(string name,string fatherName,Gender gender,string mobileNumber,string mailID)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            MobileNumber=mobileNumber;
            MailID=mailID;
        }
    }
}