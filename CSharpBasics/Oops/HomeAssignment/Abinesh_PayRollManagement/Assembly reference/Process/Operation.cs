using System;
using Library;
using System.Collections.Generic;
namespace Process
{
    public static class Operation
    {
      public static  List<PayRollDetails> payRollList=new List<PayRollDetails>();
       /// <summary>
       ///  Method Mainmenu used for the user to call register, login method
       /// choose exit option to leave from the application
       /// </summary>
      public static void Mainmenu()
      {
        string conditionMainmenu="yes";
        do
        {
            System.Console.WriteLine("_______---Main menu---________");
            System.Console.WriteLine("***********");
            System.Console.WriteLine("Choose anyone option \n1.Registration \n2.Login \n3.Exit");
            System.Console.Write("Your Option:");
            int choice=int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                      {
                        Registration();
                        break;
                      }
                case 2:
                      {
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
                        System.Console.WriteLine("---Invalid Option---");
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
            System.Console.WriteLine("-----Registration Form----");
            System.Console.Write("Enter your name: ");
            string employeeName=Console.ReadLine();
            System.Console.Write("Enter your Role:");
            string role=Console.ReadLine();
            System.Console.Write("Enter your Work Location:");
            WorkLocation workLocation=Enum.Parse<WorkLocation>(Console.ReadLine(),true);
            System.Console.Write("Enter your Team name: ");
            string teamName=Console.ReadLine();
            System.Console.Write("Enter your Date of Joining: ");
            DateTime doj=DateTime.ParseExact(Console.ReadLine(),("dd/MM/yyyy"),null);
            System.Console.Write("Enter your Number of leaves taken: ");
            float numberOfLeaves=float.Parse(Console.ReadLine());
            System.Console.Write("Enter the gender: ");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            PayRollDetails employee=new PayRollDetails(employeeName,role,workLocation,teamName,doj,numberOfLeaves,gender);
            System.Console.WriteLine("\n----successfull Registration---\n--Congratulation--\n");
            System.Console.WriteLine("Your EmployeeID: "+employee.EmployeeId);
            payRollList.Add(employee);
      }
    /// <summary>
    /// Method Login shows the submenu 
    /// if the employeeID satify the condition it call submenu method
    /// employeeID is passed as parameter to showmenu to dispaly the required customer details
    /// </summary>
    public static void Login()
    {
            int temp=0;
            System.Console.Write("Enter the EmployeeID: ");
            string employeeID=Console.ReadLine();
            foreach(PayRollDetails employee1 in payRollList)
            {
              if(employeeID==employee1.EmployeeId)
              {
                System.Console.WriteLine("---Successfull Login---");
                Submenu(employeeID);
                temp=0;
                break;
              }
              else
              {
                temp=1;
              }
            }
            if(temp==1)
            {
              System.Console.WriteLine("___---Invalid EmployeeID---____");
            }
    }
   /// <summary>
   /// Submenu shows CalculateSalary, DisplayDetails,Exit
   /// It helps user to choose the required options 
  /// EmployeeID passed as parameter for all methods to show details of required ID
   /// </summary>
   /// <param name="employeeID"></param>
    public static void Submenu(string employeeID)
    {
      string conditionSubmenu="";
      do
      {
        System.Console.WriteLine("\nchoose your choice \n1.Calculate salary \n2.Display details \n3.Exit\n");
        System.Console.Write("Your Option: ");
        int choice=int.Parse(Console.ReadLine());
        switch(choice)
        {
          case 1:
                 {
                  CalculateSalary(employeeID);
                  conditionSubmenu="yes";
                  break;
                 }
          case 2:
               {
                DisplayDetails(employeeID);
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
                    System.Console.WriteLine("---Invalid Option----");
                    conditionSubmenu="no";
                    break;
                  }      
        }
      }while(conditionSubmenu=="yes");
    }
     /// <summary>
     /// Used to calculate the salary of the user
     /// </summary>
     /// <param name="employeeID"></param>
    public static void CalculateSalary(string employeeID)
    {
      foreach(PayRollDetails employee2 in payRollList)
      {
        if(employeeID==employee2.EmployeeId)
        {
          if(employee2.NumberOfLeaves>0)
          {
          float totalWorkingsDays=30-employee2.NumberOfLeaves;
          employee2.NumberOfWorkingDays=totalWorkingsDays;
          double MonthlySalary=totalWorkingsDays*500;
          System.Console.WriteLine("\n----Total salary for working days---: "+MonthlySalary);
          }
        }
      }
    }
   /// <summary>
   /// Used to diplay the details of the user
   /// </summary>
   /// <param name="employeeID"></param>
    public static void DisplayDetails(string employeeID)
    {
      foreach(PayRollDetails employee3 in payRollList)
      {
        if(employeeID==employee3.EmployeeId)
        {
          System.Console.WriteLine($"|EmployeeID           |Employee Name       |Role        |WorkLocation      |TeamName       |DateOfJoining        |gender         |NumberOfLeaves      |");
          System.Console.WriteLine($"|{employee3.EmployeeId}          |{employee3.EmployeeName}            |{employee3.Role}          |{employee3.WorkLocation}           |{employee3.TeamName}             |{employee3.DOJ.ToString("dd/MM/yyyy")}         |{employee3.Gender}                |{employee3.NumberOfLeaves}|");
        }
      }
    }
  }
}