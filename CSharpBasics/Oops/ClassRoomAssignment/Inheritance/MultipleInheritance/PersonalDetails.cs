namespace MultipleInheritance
{
    public enum Gender{Default,Male,Femlae}
    public class PersonalDetails
    {
        private static int s_AID=1000;
        public string AID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public long PhoneNumber { get; set; }

        public PersonalDetails(string name,string fatherName,Gender gender,long phoneNumber)
        {
            s_AID++;
            AID="AID"+s_AID;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            PhoneNumber=phoneNumber;
        }


        public void ShowDetails()
        {
            System.Console.WriteLine("AID: "+AID);
            System.Console.WriteLine("Name: "+Name);
            System.Console.WriteLine("FatherName:"+FatherName);
            System.Console.WriteLine("Gender: "+Gender);
            System.Console.WriteLine("PhoneNumber: "+PhoneNumber);
        }

          public PersonalDetails(string aid,string name,string fatherName,Gender gender,long phoneNumber)
        {
            AID=aid;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            PhoneNumber=phoneNumber;
        }
    }
}