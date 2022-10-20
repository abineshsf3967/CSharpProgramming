using System;
using Library;
using System.Collections.Generic;
namespace Process;
    public static class Operations
    {
       public static List<EBBillDetails> customerList=new List<EBBillDetails>();
        /// <summary>
        ///  Method Mainmenu used for the user to call register, login method
        /// choose exit option to leave from the application
        /// </summary>
        public static void Mainmenu()
        {
            string conditionMainmenu="yes";
            do
            {
              System.Console.WriteLine("________---Main Menu---________");
              System.Console.WriteLine("Enter your option \n1.Registration \n2.Login \n3.Exit ");
              System.Console.Write("your option: ");
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
                        System.Console.WriteLine("---Invalid option---");
                        break;
                     }

              }   
            } while (conditionMainmenu=="yes");
        }
        /// <summary>
        ///  Method helps user to fill the registration form
        /// </summary>
        public static void Registration()
        {
                System.Console.WriteLine("________Start registration______");
                System.Console.Write("Enter your name: ");
                string userName=Console.ReadLine();
                System.Console.Write("Enter Phone Number: ");
                long phoneNumber=long.Parse(Console.ReadLine());
                System.Console.Write("Enter your MailID: ");
                string mailID=Console.ReadLine();
                EBBillDetails customer=new EBBillDetails(userName,phoneNumber,mailID);
                customerList.Add(customer);
                System.Console.WriteLine("\n|----Successfull Registration----|");
                System.Console.WriteLine("your MeterID : "+customer.MeterID);
        }
       /// <summary>
       /// Method Login shows the submenu 
        /// if the MeterID satify the condition it call submenu method
        /// MeterID is passed as parameter to showmenu to dispaly the required customer details
       /// </summary>
        public static void Login()
        {
                int temp=0;
                System.Console.Write("Enter your UserID: ");
                string meterID=Console.ReadLine();
                foreach(EBBillDetails customer1 in customerList)
                {
                    if(meterID==customer1.MeterID)
                    {
                        System.Console.WriteLine("\n---Successfull Login---");
                        Submenu(meterID);
                        break;
                    }
                    else
                    {
                        temp=1;
                    }
                }
                if(temp==1)
                {
                    System.Console.WriteLine("---Invalid MeterID---");
                }
        }
         /// <summary>
         /// Submenu shows CalculateAmount,DisplayUserDetails,Exit
         /// It helps user to choose the required options 
         /// EmployeeID passed as parameter for all methods to show details of required ID
         /// </summary>
         /// <param name="MeterID"></param>
        public static void Submenu(string MeterID)
        {
            string conditionSubmenu="";
            do
            {
            System.Console.WriteLine("\nChoose the Option: \n1.CalculateAmount \n2.DisplayUserDetails \n3.Exit");
            int choice=int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                      {
                        CalculateAmount(MeterID);
                        
                        conditionSubmenu="yes";
                        break;
                      }
                case 2:
                      {
                        DisplayUserDetails(MeterID);
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
                        System.Console.WriteLine("\n---Invalid Option---");
                        conditionSubmenu="yes";
                        break;
                    }       
            }
        }while(conditionSubmenu=="yes");
    }
     /// <summary>
     /// Used to calculateAmount for user
     /// </summary>
     /// <param name="MeterID"></param>
    public static void CalculateAmount(string MeterID)
    {
        foreach(EBBillDetails customer1 in customerList)
        {
          if(MeterID==customer1.MeterID)
          {
            System.Console.Write("\nEnter the unit consumed: ");
            customer1.UnitUsed=int.Parse(Console.ReadLine());
            if(customer1.UnitUsed>0)
            {
            int totalAmount=customer1.UnitUsed*5;
            System.Console.WriteLine("---Display Bill---");
            System.Console.WriteLine("MeterID: "+customer1.MeterID);
            System.Console.WriteLine("UserName: "+customer1.UserName);
            System.Console.WriteLine("TotalAmount: "+totalAmount);
            }
          }
        }  
        
    }
     /// <summary>
     /// Used to display details for the user
     /// </summary>
     /// <param name="MeterID"></param>
    public static void DisplayUserDetails(string MeterID)
    {
        foreach(EBBillDetails customer3 in customerList)
        {
            if(MeterID==customer3.MeterID)
            {
                System.Console.WriteLine($"|MeterID   |UserName    |PhoneNumber    |MailID");
                System.Console.WriteLine($"|{customer3.MeterID}    |{customer3.UserName}      |{customer3.PhoneNumber}       |{customer3.MailID}");
            }
        }
    }
}