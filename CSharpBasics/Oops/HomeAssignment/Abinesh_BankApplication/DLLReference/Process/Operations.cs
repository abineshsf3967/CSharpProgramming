using System;
using Library;
using System.Collections.Generic;
namespace Process;

    public static class Operations
    {
        public static List<BankDetails> customerList=new List<BankDetails>();
         /// <summary>
         /// Method is used to set the default user to the List
         /// </summary>
        public static void DefaultUser()
        {
            DateTime dob1=new DateTime(2000/12/11);
            BankDetails abinesh=new BankDetails("Abinesh",Gender.Male,6382600921,"abineshp@22",dob1);
            customerList.Add(abinesh);
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
                System.Console.WriteLine("---Main menu---");
                System.Console.WriteLine("**************");
                System.Console.WriteLine("Choose any Option \n1.Registration \n2.Login \n3.Exit");
                System.Console.Write("Enter your option: ");
                int choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                          {
                            System.Console.WriteLine("\n ---Registration Form---");
                            Registration();
                            break;
                          }
                    case 2:
                          {
                            System.Console.WriteLine("\n---Login---");
                            Login();
                            break;
                          }      
                    case 3:
                         {
                           conditionMainmenu="no";
                           break;   
                         }    
                    default :
                          {
                            System.Console.WriteLine("Invalid Option");
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
                System.Console.Write("Enter your Name: ");
                string customername=Console.ReadLine();
                System.Console.Write("Enter your Gender (male or female or transgender): ");
                Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
                System.Console.Write("Enter your mobile number: ");
                long mobileNumber=long.Parse(Console.ReadLine());
                System.Console.Write("Enter your mail ID:");
                string mailID=Console.ReadLine();
                System.Console.Write("Enter the date in format-(dd/MM/yyyy): ");
                DateTime dob=DateTime.ParseExact(Console.ReadLine(),("dd/MM/yyyy"),null);
                BankDetails customer1=new BankDetails(customername,gender,mobileNumber,mailID,dob);
                System.Console.WriteLine("\n---Account created Successfull!---\n---Congratulation!---");
                System.Console.WriteLine("***************");
                System.Console.Write("Your Customer Id: "+customer1.CustomerID+"\n");
                customerList.Add(customer1);
                System.Console.Write("If you want to continue yes or no : ");
                conditionRegistration=Console.ReadLine().ToLower();
            }while(conditionRegistration=="yes");
            
        }
        
        /// <summary>
        /// Method Login shows the submenu 
        /// if the customerID satify the condition it call submenu method
        /// customerID is passed as parameter to showmenu to dispaly the required customer details
        /// </summary>
        public static void Login()
        {
            string conditionLogin="";
            do
            {
            int temp=0;
            System.Console.Write("Enter your Customer ID:");
            string customerID=Console.ReadLine();
            foreach(BankDetails customer1 in customerList)
            {
                if(customerID==customer1.CustomerID)
                {
                   System.Console.WriteLine("\n---Login successfull---");
                   SubMenu(customerID);
                   break;
                }
                else
                {
                     temp=1;
                }
            }
            if(temp==1)
            {
                System.Console.WriteLine("---Invalid Customer ID---");
                System.Console.Write("Do you want to continue Login (yes or no):");
                conditionLogin=Console.ReadLine().ToLower();                
            }
            }while(conditionLogin=="yes");
        }
         /// <summary>
         /// Submenu shows Deposit, Withdraw, Balance, Exit
         /// It helps user to choose the required options 
         /// customerID passed as parameter for all methods to show details of required ID
         /// </summary>
         /// <param name="customerID"></param>
        public static void SubMenu(string customerID)
        {
            string checkSubmenu="";
            do
            {
                System.Console.WriteLine("Enter the your choice \n1.Deposit \n2.withdraw \n3.balance \n4.Exit");
                System.Console.Write("Enter your option: ");
                int choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                         {
                            Deposit(customerID);
                            checkSubmenu="yes";
                            break;
                         }
                    case 2:
                          {
                            Withdraw(customerID);
                            checkSubmenu="yes";
                            break;
                          }     
                    case 3:
                         {
                            Balance(customerID);
                            checkSubmenu="yes";
                            break;
                         }      
                    case 4:
                         {
                            checkSubmenu="no";
                            break;
                         }     
                    default:
                         {
                            System.Console.WriteLine("invalid option");
                            checkSubmenu="no";
                            break;
                         }     
                }

            }while(checkSubmenu=="yes");
        }
        /// <summary>
        /// Deposit method shows the amount deposited in account
        /// </summary>
        /// <param name="customerID"></param>
        public static void Deposit(string customerID)
        {
            System.Console.Write("\n Enter your deposit amount here :");
            double deposit=double.Parse(Console.ReadLine());
            foreach(BankDetails customer2 in customerList)
            {
              if(customerID==customer2.CustomerID)
              {
                if(deposit>0)
                {
                customer2.Balance=customer2.Balance+deposit;
                System.Console.WriteLine("\n---Total balance after deposit---: "+customer2.Balance);
                }
                else
                {
                    System.Console.WriteLine("----Invalid amount---");
                }
              }
            }
        }
        /// <summary>
        /// Withdraw shows amount that withdraw from the account
        /// It shows remaining balance in account
        /// </summary>
        /// <param name="customerID"></param>
        public static void Withdraw(string customerID)
        {
            System.Console.Write("\n Enter the withdraw amount here : ");
            double withdraw=double.Parse(Console.ReadLine());
            foreach(BankDetails customer2 in customerList)
            {
                if(customerID==customer2.CustomerID)
                {
                    if(withdraw<customer2.Balance)
                    {
                        if(withdraw>0)
                        {
                        customer2.Balance=customer2.Balance-withdraw;
                        System.Console.WriteLine("--------------------------------");
                        System.Console.WriteLine("       Total balance after withdraw   : "+customer2.Balance);
                        }
                        else
                        {
                            System.Console.WriteLine("\n---Invalid amount---");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("Insuffient balance \n---Check balance---");
                    }
                }
            }
        }
        /// <summary>
        /// Balance method show the balance in account of required customer
        /// </summary>
        /// <param name="customerID"></param>
        public static void Balance(string customerID)
        {
            foreach(BankDetails customer2 in customerList)
            {
                if(customerID==customer2.CustomerID)
                {
                    System.Console.WriteLine("\n ******************");
                    System.Console.WriteLine("-----Total balance in account: "+customer2.Balance+"\n");
                }
            }
        }
}