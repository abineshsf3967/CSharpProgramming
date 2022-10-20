namespace BloodBankManagement
{
    public enum BloodGroup{Default,A_Positive,B_Positive,O_Positive,AB_Positive}
    public class UserDetails
    {
        private static int s_donorID=1000;
        public string DonorID { get;  }
        public string DonorName { get; set; }
        public long MobileNumber { get; set; }
        public BloodGroup BloodGroup { get; set; }
        public int Age { get; set; }
        public string NativePlace { get; set; }

        public UserDetails(string donorName,long mobileNumber,BloodGroup bloodGroup,int age,string nativePlace)
        {
            s_donorID++;
            DonorID="UID"+s_donorID;
            DonorName=donorName;
            MobileNumber=mobileNumber;
            BloodGroup=bloodGroup;
            Age=age;
            NativePlace=nativePlace;
        }
        
        
        
        
        
        
        
        
        
        
        
        
    }
}