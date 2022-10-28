namespace BlackTicket
{
    public class PersonalDetails
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string MobileNumber { get; set; }
        public PersonalDetails()
        {
            
        }

        public PersonalDetails(string name,int age,string mobileNumber)
        {
            Name=name;
            Age=age;
            MobileNumber=mobileNumber;
        }

    }
}