using System;
namespace BloodBankManagement
{
    public class DonationDetails
    {
        private static int s_donationID=1000;
        public string DonationID { get; set; }
        public string DonorID { get; set; }
        public DateTime DonationDate { get; set; }
        public double Weight { get; set; }
        public double BloodPressure { get; set; }
        public double HemoglobinCount { get; set; }


        public DonationDetails(string donorID,DateTime donationDate,double weight,double bloodPressure,double hemoglobinCount)
        {
            s_donationID++;
            DonationID="DID"+s_donationID;
            DonorID=donorID;
            DonationDate=donationDate;
            Weight=weight;
            BloodPressure=bloodPressure;
            HemoglobinCount=hemoglobinCount;
        }
        
        
        
        
        
        
        
        
        
        
        
        
    }
}