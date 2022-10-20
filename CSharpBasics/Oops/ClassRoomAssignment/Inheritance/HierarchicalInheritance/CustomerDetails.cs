namespace HierarchicalInheritance
{
    public class CustomerDetails:PersonalDetails
    {
        private static int s_customerID=100;
        public string CustomerID { get; }
        public double Balance { get; set; }

        public CustomerDetails(string aid,string name,string fatherName,Gender gender,long phoneNumber,double balance):base(aid,name,fatherName,gender,phoneNumber)
        {
            s_customerID++;
            CustomerID="CID"+s_customerID;
            Balance=balance;
        }
        public void ShowCustomer()
        {
            System.Console.WriteLine("CustomerID: "+CustomerID);
            ShowDetails();
            System.Console.WriteLine("Balance: "+Balance);
        }
    }
}