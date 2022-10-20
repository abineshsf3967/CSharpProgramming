using System;
using System.Collections.Generic;

namespace StudentAdmission;

    public static class Operations
    {
     public static List<StudentDetails> studentList=new List<StudentDetails>();
       /// <summary>
       /// Method is used to set the default user to the List
       /// </summary>
       public static void DefaultUser()
          {
            DateTime dob1=new DateTime(2001,11,12);
            StudentDetails abinesh=new StudentDetails("abinesh","Palanisamy",dob1,Gender.Male,"abineshp@22",98,97,96);
            studentList.Add(abinesh);
            DateTime dob2=new DateTime(2001,11,12);
            StudentDetails sam=new StudentDetails("sam","samiulla",dob2,Gender.Male,"sam@23",78,98,99);
            studentList.Add(sam);
          }
          /// <summary>
          /// Method Mainmenu used for the user to call register, login method
          /// choose exit option to leave from the application
          /// </summary>
     public static void Mainmenu()
        {
          DefaultUser();
          string conditionMainmenu="yes";
        do
            {
            System.Console.WriteLine("Main menu");
            System.Console.WriteLine("********");
            System.Console.WriteLine("Select your option: \n1.Registration \n2.Login \n3.Exit");
            System.Console.Write("Your option:");
            int choice=int.Parse(Console.ReadLine());
          switch(choice)
          {
            case 1:
                  {
                    System.Console.WriteLine();
                    System.Console.WriteLine("---Registration Called---");
                    System.Console.WriteLine();
                    Registration();
                    break;
                  }
            case 2:
                  {
                    System.Console.WriteLine();
                    System.Console.WriteLine("---Login Called---");
                    System.Console.WriteLine();
                    Login();
                    break;
                  }      
            case 3:
                {
                    conditionMainmenu="no";
                    break;
                }   
            default:
                   {
                    System.Console.WriteLine("---Invalid Answer---\n");
                    Mainmenu();
                    break;
                   }      
          }
        
        }while(conditionMainmenu=="yes"); 
    }  
     /// <summary>
     /// Method helps user to fill the registration form
     /// </summary>

        public static void Registration()
          { 
            string conditionRegistration="";
            do
             {
                System.Console.WriteLine("---Student Registration from---");
                System.Console.Write("Enter your studentName: ");
                string studentName=Console.ReadLine();
                System.Console.Write("Enter your Father's name: ");
                string fatherName=Console.ReadLine();
                System.Console.Write("select your the gender male or female or transgender: ");
                Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
                System.Console.Write("Enter your DOB (dd/MM/yyy): ");
                DateTime dob=DateTime.ParseExact(Console.ReadLine(),("dd/MM/yyyy"),null);
                System.Console.Write("Enter your mail ID: ");
                string mailID=Console.ReadLine();
                System.Console.Write("Enter your physics mark: ");
                int physicsMark=int.Parse(Console.ReadLine());
                System.Console.Write("Enter your chemistry mark: ");
                int chemistryMark=int.Parse(Console.ReadLine());
                System.Console.Write("Enter your maths mark: ");
                int mathsMark=int.Parse(Console.ReadLine());
                StudentDetails student1 = new StudentDetails(studentName,fatherName,dob,gender,mailID,physicsMark,chemistryMark,mathsMark);
                System.Console.WriteLine();
                System.Console.WriteLine("Registration successfull!");
                System.Console.WriteLine("Your registration Id is: "+student1.RegistrationID+"\n");
                studentList.Add(student1);
                System.Console.Write("Do you want continue  yes/no: ");
                conditionRegistration=Console.ReadLine().ToLower();
            }   while(conditionRegistration=="yes");
          }
           /// <summary>
           /// Method Login shows the submenu 
           /// if the registrationID satify the condition it call submenu method
           /// ID is passed as parameter to showmenu to dispaly the required student details
           /// </summary>
          public static void Login()
          {
            string checkLogin="";
            do
            {
             int temp=0;
             System.Console.Write("Enter the Registration ID:");
             string registrationID=Console.ReadLine();
             foreach(StudentDetails student2 in studentList)
             {
              if(registrationID==student2.RegistrationID)
              {
                System.Console.WriteLine("\n---Successful login!---");
                System.Console.WriteLine();
                Submenu(registrationID);
                break;
              }
              else
              {
                temp=1;
              }
             }
             if(temp==1)
              {
                System.Console.WriteLine("---Invalid registration ID---");
                System.Console.Write("Do you want to continue to login (yes or no) : ");
                checkLogin=Console.ReadLine().ToLower();
              }
            }while(checkLogin=="yes");
          }
         /// <summary>
         /// ubmenu shows CheckEligibility, ShowDetails, exit
         /// It helps user to choose the required options 
         /// RegistrationID passed as parameter for all methods to show details of required ID
         /// </summary>
         /// <param name="registrationID"></param>
          public static void Submenu(string registrationID)
          {
            string conditionSubmenu="";
            do
            { 
             System.Console.WriteLine("Select the option \n1.Eligibility check \n2.ShowDetails \n3.Exit \n");
             System.Console.Write("Your option:");
             int choice=int.Parse(Console.ReadLine());
             switch(choice)
             {
                 case 1:
                       {
                        string ID=registrationID;
                        EligibilityCheck(ID);
                        conditionSubmenu="yes";
                        break;
                       }
                 case 2:
                        {
                          
                            ShowDetails(registrationID);
                            conditionSubmenu="yes";
                            break;
                        }     
                 case 3:
                        {
                          conditionSubmenu="no";
                          break;

                        }       
                  default:
                         {
                          System.Console.WriteLine("\n---Invalid Answer---\n");
                          conditionSubmenu="yes";
                          break;
                         }      
             }
             }while(conditionSubmenu=="yes");  
           }
         /// <summary>
         /// Eligibility used to check your are eligible for admission
         /// </summary>
         /// <param name="ID"></param>
          public static void EligibilityCheck(String ID)
          {
            foreach(StudentDetails student in studentList)
            { 
              if(ID==student.RegistrationID)
              {
              bool eligiblity=student.CheckEligibility(75.0);
              if(eligiblity)
              {
                System.Console.WriteLine();
                System.Console.WriteLine("you are eligible! \n");
              }
              else
              {
                System.Console.WriteLine();
                System.Console.WriteLine("you are not eligible \n");
              }
              }
            }
          }
          /// <summary>
          /// It shows the entire details based on required RegistrationID
          /// </summary>
          /// <param name="ID"></param>
          public static void ShowDetails(string ID)
          {
            foreach(StudentDetails student in studentList)
            {
              if(ID==student.RegistrationID)
              {
                System.Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------");
                System.Console.WriteLine($"|Registration ID | Student name | Father name  |  Gender  |     DOB    |      Mail ID      |  Physics mark | Chemistry mark |Maths mark|");
                System.Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------");
                System.Console.WriteLine($"     {student.RegistrationID}      | {student.StudentName}    |  {student.FatherName}    | {student.Gender} |   {student.DOB.ToString("dd/MM/yyyy")} |     {student.MailID} |          {student.PhysicsMark}   |           {student.ChemistryMark}    |         {student.MathsMark}     |");
                System.Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------");
              }
            }
          
          }
} 
