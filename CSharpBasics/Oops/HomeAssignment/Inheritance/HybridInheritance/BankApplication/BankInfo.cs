namespace BankApplication
{
    public class BankInfo
    {
        public string BankName { get; set; }
        public string IFSC { get; set; }
        public string Branch { get; set; }


        public BankInfo(string bankName,string ifsc,string branch)
        {
            BankName=bankName;
            IFSC=ifsc;
            Branch=branch;
        }
    }
}