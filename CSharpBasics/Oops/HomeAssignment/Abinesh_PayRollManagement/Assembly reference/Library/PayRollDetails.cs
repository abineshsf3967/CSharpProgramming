using System;
/// <summary>
/// Used to process the PayRoll Management using this application
/// </summary>
namespace Library
{
    /// <summary>
    /// Used to choose the employee gender information
    /// </summary>
    public enum Gender{Default,Male,Female,Transgender}
    /// <summary>
    /// Used to choose the employee gender information
    /// </summary>
    public enum WorkLocation{Default,Mathura,Eymard,Karuna}
    /// <summary>
    /// CLass <see cref="PayRollDetails" /> used to collect employee details for the PayRoll process
    /// </summary>
    public class PayRollDetails
    {
        /// <summary>
        /// Static field is used to auto increment and it uniquely identify an instance of
        /// </summary>
        private static int s_employeeId =1001;
        /// <summary>
        /// Property EmployeeID used to uniquely identify a <see cref="PayRollDetails" /> class's object
        /// </summary>
        /// <value></value>
        public string EmployeeId { get; set; }
        /// <summary>
        /// Property EmployeeName is used to provide name for a employee in object of <see  cref="StudentDetails" /> class
        /// </summary>
        /// <value></value>
        
        public string EmployeeName { get; set; }
        /// <summary>
        /// Property EmployeeRole is used to provide role for a employee in object of <see  cref="StudentDetails" /> class
        /// </summary>
        /// <value></value>
        public string Role { get; set; }
        /// <summary>
        /// Property Employee WorkLocation is used to provide WorkLocation for a employee in object of <see  cref="StudentDetails" /> class
        /// </summary>
        /// <value></value>
        public WorkLocation WorkLocation { get; set; }
        /// <summary>
        /// Property EmployeeTeam is used to provide TeamName for a employee in object of <see  cref="StudentDetails" /> class
        /// </summary>
        /// <value></value>
        public string TeamName { get; set; }
        /// <summary>
        /// Property Employee DOJ is used to provide DOJ for a employee in object of <see  cref="StudentDetails" /> class
        /// </summary>
        /// <value></value>
        public DateTime DOJ { get; set; }
        /// <summary>
        /// Property Employee NumberWorkingDays is used to provide NumberOfWorkingDays for a employee in object of <see  cref="StudentDetails" /> class
        /// </summary>
        /// <value></value>
        public float  NumberOfWorkingDays { get; set; }
        /// <summary>
        /// Property Employee NumberOfLeaves is used to provide NumberOfLeaves for a employee in object of <see  cref="StudentDetails" /> class
        /// </summary>
        /// <value></value>
        public float NumberOfLeaves { get; set; }
        /// <summary>
        /// Property Employee Gender is used to provide Gender for a employee in object of <see  cref="StudentDetails" /> class
        /// </summary>
        /// <value></value>
        public Gender Gender { get; set; }


        public PayRollDetails()
        {
            EmployeeName="Your name";
            Role ="Your role";
            TeamName ="your team name";
        }
         /// <summary>
         /// Constructor of <see cref="PayRollDetails" /> class used to initialize values to its properties
         /// </summary>
         /// <param name="employeeName"></param>Parameter employeeName used to initialize a EmployeeName to Name property
         /// <param name="role"></param>Parameter role used to initialize a EmployeeName to Name property
         /// <param name="workLocation"></param>Parameter workLocation used to initialize a WorkLocation Name to Name property
         /// <param name="teamName"></param>Parameter teaamName used to initialize a TeamName to Name property
         /// <param name="doj"></param>Parameter doj used to initialize a DOJ to Name property
         /// <param name="numberOfLeaves"></param>Parameter numberOfLeaves used to initialize a NumberOfLeaves to Name property
         /// <param name="gender"></param>Parameter gender used to initialize a Gender to Name property

        public PayRollDetails(string employeeName,string role,WorkLocation workLocation,string teamName,DateTime doj,float numberOfLeaves,Gender gender)
        {
            s_employeeId++;
            EmployeeId="SF"+ s_employeeId;
           EmployeeName = employeeName;
           Role = role;
           WorkLocation=workLocation;
           TeamName = teamName;
           DOJ = doj;
           NumberOfLeaves=numberOfLeaves;
           Gender=gender;
        }
    }
}