using System;
using System.Collections.Generic;
namespace OnlineMedicalStore;

/// <summary>
///  Operations class contains methods for operation
/// </summary>
    public static class Operations
    {
         public static List<UserDetails> userList=new List<UserDetails>();
         public static List<MedicineDetails> medicineList=new List<MedicineDetails>();
          public static List<OrderDetails> orderList=new List<OrderDetails>();
          /// <summary>
          /// MainMenu is used to register,login and exit 
          /// </summary>
          public static void MainMenu()
          {
            string choice="yes";
            do
            {
                System.Console.WriteLine("----Main Menu-----");
                System.Console.WriteLine("Choose the Option \n1.UserRegistration \n2.UserLogin \n3.Exit");
                System.Console.Write("Your option: ");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                          {
                            System.Console.WriteLine("\n---Registration menu---\n");
                            UserRegistration();
                            break;
                          }
                    case 2:
                          {
                            System.Console.WriteLine("\n----Login Menu----\n");
                            UserLogin();
                            break;
                          }      
                    case 3:
                           {
                            System.Console.WriteLine("\n----Exiting Menu----\n");
                            choice="no";                           
                             break;
                           }      
                }
            }while(choice=="yes");
          }
       /// <summary>
       /// Registration method used to register the new user
       /// </summary>
          public static void UserRegistration()
          {
            System.Console.WriteLine("\n----Registration Start----\n");
            System.Console.Write("Enter your Name: ");
            string userName=Console.ReadLine();
            System.Console.Write("Enter your Age: ");
            int age=int.Parse(Console.ReadLine());
            System.Console.Write("Enter your City: ");
            string city=Console.ReadLine();
            System.Console.Write("Enter your PhoneNumber: ");
            long phoneNumber=long.Parse(Console.ReadLine());
            System.Console.Write("Enter your Balance: ");
            double balance=double.Parse(Console.ReadLine());
            UserDetails user=new UserDetails(userName,age,city,phoneNumber,balance);
            userList.Add(user);
            System.Console.WriteLine("\n___Successfully Registered_____\n");
            System.Console.WriteLine("\nYour UserID: "+user.UserID+"\n");
          }

         /// <summary>
         /// Login used to go to submenu
         /// And check the userID is Valid
         /// </summary>
          public static void UserLogin()
          {
            int temp=0;
            System.Console.WriteLine("\n----Start Login----\n");
            System.Console.WriteLine("Enter your UserID: ");
            string userID=Console.ReadLine().ToUpper();
            foreach(UserDetails user in userList)
            {
                if(userID==user.UserID)
                {
                    System.Console.WriteLine("\n----SubMenu----\n");
                    SubMenu(user);
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
                System.Console.WriteLine("\n---Invalid ID---\n");
            }
          }

            /// <summary>
            /// Submenu display option of different operation
            /// </summary>
            /// <param name="user"></param>
          public static void SubMenu(UserDetails user)
          {
            string choice="yes";
            do
            {
                System.Console.WriteLine("\n---SubMenu----\n");
                System.Console.WriteLine("Choose the option \n1.ShowMedicineList \n2.PurchaseMedicine \n3.CancelPurchase \n4.ShowPurchaseHistory \n5.Recharge \n6.Exit");
                System.Console.Write("Your Option: ");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        {
                            System.Console.WriteLine("\n---ShowMedicineList---\n");
                            ShowMedicineList();
                            break;
                        }
                    case 2:
                         {
                            System.Console.WriteLine("\n---PurchaseMedicine---\n");
                            PurchaseMedicine(user);
                            break;
                         }    
                    case 3:
                         {
                            System.Console.WriteLine("\n---CancelPurchase----\n");
                            CancelPurchase(user);
                            break;
                         }     
                    case 4:
                        {
                            System.Console.WriteLine("\n----ShowPurchaseHistory----\n");
                            ShowPurchaseHistory(user);
                            break;
                        }     
                    case 5:
                        {
                            System.Console.WriteLine("\n----Recharge---\n");
                            Recharge(user);
                            break;
                        }    
                    case 6:
                         {
                            System.Console.WriteLine("\n----Exiting SubMenu----\n");
                            choice="no";
                            break;
                         }    
                }
            }while(choice=="yes");
          }


        /// <summary>
        /// it show the Medicine List
        /// </summary>
          public static void ShowMedicineList()
          {
            foreach(MedicineDetails medicine in medicineList)
            {
                System.Console.WriteLine($"|MedicineID:{medicine.MedicineID}   |MedicineName:{medicine.MedicineName}  |AvailableCount:{medicine.AvailabilityCount}  |Price:{medicine.Price}    |DateOfExpiry:{medicine.DateOfExpiry.ToString("dd/MM/yyyy")}|");
                System.Console.WriteLine();
            }
          }

      /// <summary>
      /// it shows the purchase option for logged user
      /// </summary>
      /// <param name="user"></param>
          public static void PurchaseMedicine(UserDetails user)
          {
            ShowMedicineList();
            System.Console.Write("\nEnter the MedicineID,Which you want: ");
            string medicineID=Console.ReadLine().ToUpper();
            System.Console.WriteLine("How much do you want,\nEnter the count: ");
            int count=int.Parse(Console.ReadLine());
            int temp=0;
            foreach(MedicineDetails medicine in medicineList)
            {
                if(medicineID==medicine.MedicineID)
                {
                    int flag=0;
                    if(count<medicine.AvailabilityCount && count>0)
                    {
                        int next=0;
                        if(user.Balance>(medicine.Price*count))
                        {
                            DateTime expiry=medicine.DateOfExpiry;
                            int check=DateTime.Compare(DateTime.Now,expiry);
                            if(check>0)
                            {
                                System.Console.WriteLine("\n---Medicine expired---\n");
                                temp=0;
                                break;
                            }
                            else
                            {
                                double totalAmount=medicine.Price*count;
                                System.Console.WriteLine("Total Amount of medicine: "+totalAmount);
                                System.Console.WriteLine("Order date: "+DateTime.Now.ToString("dd/MM/yyyy"));
                                medicine.AvailabilityCount-=count;
                                user.Balance-=totalAmount;
                                OrderDetails order1=new OrderDetails(user.UserID,medicine.MedicineID,count,totalAmount,DateTime.Now,OrderStatus.Purchased);
                                System.Console.WriteLine("\n---Medicine was purchased Successfully----\n"); 
                                temp=0;
                            }
                            next=0;
                            break;
                        }
                        else
                        {
                           next=1;
                        }
                        if(next==1)
                        {
                            System.Console.WriteLine("\n---Invalid Balance---\n");
                            temp=0;
                        }
                        flag=0;
                        break;
                    }
                    else
                    {
                        flag=1;
                    }
                    if(flag==1)
                    {
                        System.Console.WriteLine("\n--- Invalid count---\n");
                        temp=0;
                    }
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
                System.Console.WriteLine("---Invalid ID---");
            }
          }

          /// <summary>
          /// it used to cancel the order for medicine of logged user
          /// </summary>
          /// <param name="user"></param>
          public static void CancelPurchase(UserDetails user)
          {
            foreach(OrderDetails order in orderList)
            {
                if(user.UserID==order.UserID && order.Orderstatus ==OrderStatus.Purchased)
                {
                    System.Console.WriteLine($"OrderID:{order.OrderID}|UserID:{order.UserID}|MedicineID:{order.MedicineID}|MedicineCount:{order.MedicineCount}|TotalPrice:{order.TotalPrice}|OrderDate:{order.OrderDate.ToString("dd/MM/yyyy")}|OrderStatus:{order.Orderstatus}|");
                }
            }
            System.Console.Write("Enter your OrderID: ");
            string orderID=Console.ReadLine().ToUpper();
            int temp=0;
            foreach(OrderDetails order in orderList)
            {
                if(orderID==order.OrderID && order.Orderstatus ==OrderStatus.Purchased )
                {
                    foreach(MedicineDetails medicine in medicineList)
                    {
                        if(order.MedicineID==medicine.MedicineID)
                        {
                            medicine.AvailabilityCount+=order.MedicineCount;
                            user.Balance+=order.TotalPrice;
                            order.Orderstatus=OrderStatus.Cancelled;
                            System.Console.WriteLine(order.OrderID+"was cancelled successfully");
                            temp=0;
                            break;
                        }
                    }
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
                System.Console.WriteLine("\n----Invalid ID---\n");
            }
          }
          /// <summary>
          /// it show the purchse history of required user
          /// </summary>
          /// <param name="user"></param>
          public static void ShowPurchaseHistory(UserDetails user)
          {
            foreach(OrderDetails order in orderList)
            {
                if(user.UserID==order.UserID)
                {
                    System.Console.WriteLine($"|OrderID:{order.OrderID}   |UserID:{order.UserID}     |MedicineID:{order.MedicineID}     |MedicineCount:{order.MedicineCount}    |TotalPrice:{order.TotalPrice}     |OrderDate:{order.OrderDate.ToString("dd/MM/yyyy")}    |OrderStatus:{order.Orderstatus}|");
                }
            }
          }
           /// <summary>
           /// it used to increase the wallet balance of the user looged in
           /// </summary>
           /// <param name="user"></param>
          public static void Recharge(UserDetails user)
          {
            System.Console.Write("Enter the amount to be recharged: ");
            double amount=double.Parse(Console.ReadLine());
            user.Balance+=amount;
          }
  
        public static void DefaultUser()
        {

        UserDetails user1=new UserDetails("Ravi",33,"Theni",98777744440,400);
        userList.Add(user1);
        UserDetails user2=new UserDetails("Baskaran",33,"Chennai",8847757470,500);
        userList.Add(user2);

        MedicineDetails medicine1=new MedicineDetails("Paracitamol",40,5,new DateTime(2022,06,30));
        medicineList.Add(medicine1);
        MedicineDetails medicine2=new MedicineDetails("Clapol",10,5,new DateTime(2022,05,30));
        medicineList.Add(medicine2);
        MedicineDetails medicine3=new MedicineDetails("Gelucil",3,40,new DateTime(2022,04,30));
        medicineList.Add(medicine3);
        MedicineDetails medicine4=new MedicineDetails("Metrogel",5,50,new DateTime(2022,10,30));
        medicineList.Add(medicine4);
        MedicineDetails medicine5=new MedicineDetails("Povidin Lodin",10,50,new DateTime(2022,10,30));
        medicineList.Add(medicine5);

        OrderDetails order1=new OrderDetails(user1.UserID,medicine1.MedicineID,3,15,new DateTime(2022,05,13),OrderStatus.Purchased);
        orderList.Add(order1);
        OrderDetails order2=new OrderDetails(user1.UserID,medicine2.MedicineID,2,10,new DateTime(2022,05,13),OrderStatus.Cancelled);
        orderList.Add(order2);
        OrderDetails order3=new OrderDetails(user1.UserID,medicine4.MedicineID,2,100,new DateTime(2022,05,13),OrderStatus.Purchased);
        orderList.Add(order3);
        OrderDetails order4=new OrderDetails(user2.UserID,medicine3.MedicineID,3,120,new DateTime(2002,05,15),OrderStatus.Cancelled);
        orderList.Add(order4);
        OrderDetails order5=new OrderDetails(user2.UserID,medicine5.MedicineID,5,250,new DateTime(2022,05,15),OrderStatus.Purchased);
        orderList.Add(order5);
        OrderDetails order6=new OrderDetails(user2.UserID,medicine2.MedicineID,3,15,new DateTime(2022,05,15),OrderStatus.Purchased);
        orderList.Add(order6);
        }
    }
