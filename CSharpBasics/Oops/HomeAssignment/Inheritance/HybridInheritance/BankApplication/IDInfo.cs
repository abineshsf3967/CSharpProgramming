using System;
namespace BankApplication
{
    public class IDInfo:PersonalInfo
    {
        public string VoterID { get; set; }
        public int AadharID { get; set; }
        public string PANNumber { get; set; }

        public IDInfo(string name,Gender gender,DateTime dob,long mobileNumber,string voterID,int aadharID,string panNumber):base(name,gender,dob,mobileNumber)
        {
            VoterID=voterID;
            AadharID=aadharID;
            PANNumber=panNumber;
        }
    }
}