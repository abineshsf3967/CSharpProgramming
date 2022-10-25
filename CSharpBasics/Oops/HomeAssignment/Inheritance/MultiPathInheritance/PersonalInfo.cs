using System;
namespace MultiPathInheritance
{
    public enum Gender{Default,Male,Female}
    public interface PersonalInfo
    {
         int AdharNumber { get; set; }
         string Name { get; set; }
         string FatherName { get; set; }
         long MobileNumber { get; set; }
         DateTime DOB { get; set; }
         Gender Gender { get; set; }

    }
}