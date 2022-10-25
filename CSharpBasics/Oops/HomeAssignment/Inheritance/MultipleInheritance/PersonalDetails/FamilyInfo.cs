namespace PersonalDetails
{
    public interface IFamilyInfo
    {
        string FatherName { get; set; }
        string MotherName { get; set; }
        string Address { get; set; }
        int NoOfSiblings { get; set; }
    }
}