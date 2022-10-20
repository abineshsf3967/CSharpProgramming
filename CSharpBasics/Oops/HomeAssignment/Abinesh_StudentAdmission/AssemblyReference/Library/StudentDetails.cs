using System;
/// <summary>
/// Used to process the student admission using this application
/// </summary>
namespace Library
{ 
    /// <summary>
    /// Used to choose the student gender information
    /// </summary>
    public enum Gender{Default,Male,Female,Transgender}
    /// <summary>
    /// CLass <see cref="StudentDetails" /> used to collect student's details for the admission process
    /// </summary>
    public class StudentDetails
    {
        //Field
        /// <summary>
        /// Static field is used to auto increment and it uniquely identify an instance of
        /// <see cref="StudentDetails" /> class
        /// </summary>
        private static int s_registrationID=3000;
        /// <summary>
        /// Property RegistrationID used to uniquely identify a <see cref="StudentDetails" /> class's object
        /// </summary>
        public string RegistrationID { get; set; } //property
        
        /// <summary>
        /// Property StudentName is used to provide name for a student in object of <see  cref="StudentDetails" /> class
        /// </summary>
        /// <value>0 to 100</value>
        public string StudentName { get; set; }
        /// <summary>
        /// Property FatherName is use to provide  fatherName for a student in object of <see cref="StudentDetails" /> class
        /// </summary>
        public string FatherName { get; set; }
        /// <summary>
        /// Property DOB is use to provide dob for a student in object of <see cref="StudentDetails" /> class
        /// </summary>
        public DateTime DOB { get; set; }
        /// <summary>
        /// Property Gender is used to provide Gender for a student in object of <see cref="StudentDetails" /> class
        /// </summary>
        public Gender Gender { get; set; }
        /// <summary>
        /// Property MailID  is ued to provide MailID for a student in object of <see cref="StudentDetails" /> class
        /// </summary>
        public string MailID { get; set; }
        /// <summary>
        ///  Property PhysicsMark  is ued to provide PhysicsMark for a student in object of <see cref="StudentDetails" /> class
        /// </summary>
        public int PhysicsMark { get; set; }
        /// <summary>
        ///  Property ChemistryMark  is ued to provide chemistry mark for a student in object of <see cref="StudentDetails" /> class
        /// </summary>
        public int ChemistryMark { get; set; }
        /// <summary>
        ///  Property MathsMark is ued to provide maths mark for a student in object of <see cref="StudentDetails" /> class
        /// </summary>
        public int MathsMark { get; set; }
         
         public StudentDetails()
         {
            RegistrationID="your ID";
            StudentName="your name";
            FatherName="your Father Name";
            MailID="your MailID";
         }
         /// <summary>
         /// Constructor of <see cref="StudentDetails" /> class used to initialize values to its properties
         /// </summary>
         /// <param name="name">Parameter name used to initialize a Student's Name to Name property</param>
         /// <param name="fatherName">Parameter Fathername used to initialize a Student's Father's Name to Name property
         /// <param name="dob"></param>Parameter dob used to initialize a Student's dob to Name property
         /// <param name="gender"></param>Parameter gender used to initialize a Student's gender to Name property
         /// <param name="mailId"></param>Parameter mailID used to initialize a Student's mailID to Name property
         /// <param name="physicsMark"></param>Parameter Physicsmark used to initialize a Student's physicsMark to Name property
         /// <param name="chemistryMark"></param>Parameter Chemistrymark used to initialize a Student's chemistryMark to Name property
         /// <param name="mathsMark"></param>Parameter Mathsmark used to initialize a Student's mathsMark to Name property
       public StudentDetails(string name,string fatherName,DateTime dob,Gender gender,string mailId,int physicsMark,int chemistryMark,int mathsMark)
        {
            s_registrationID++;
            RegistrationID="SF"+s_registrationID;
            StudentName = name;
            FatherName = fatherName;
            DOB = dob;
            Gender = gender;
            MailID = mailId;
            PhysicsMark = physicsMark;
            ChemistryMark = chemistryMark;
            MathsMark = mathsMark;
        }    

        ~StudentDetails()
        {
            System.Console.WriteLine("The destructor called so application is closing");
        }
          /// <summary>
          /// Method check eligibility get cutoff value as parameter and checks the eligibility of student
          /// If cutoff is less or equal then student is eligible and will return true else false
          /// </summary>
          /// <param name="cutoff">Used to provide cutoff value for eligibility checking</param>
          /// <returns>Returns true if eligible else false</returns>
        public bool CheckEligibility(double cutoff)
        {
            double average=(double)(PhysicsMark+MathsMark+ChemistryMark);
            if(average>=cutoff)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}