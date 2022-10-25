namespace RuntimePolymorphism
{
    public enum Gender{Default,Male,Female}
    public abstract class PersonalInfo
    {
        public  string Name { get; set; }
        public string FatherName { get; set; }
        public long MobileNumber { get; set; }
        public  Gender Gender { get; set; }

        public PersonalInfo(string name,string fatherName,long mobileNumber,Gender gender)
        {
            Name=name;
            FatherName=fatherName;
            MobileNumber=mobileNumber;
            Gender=gender;
        }
         public abstract void Display();
    }
}