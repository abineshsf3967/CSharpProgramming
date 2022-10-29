using System;
namespace CafeteriaApplication;

 public delegate void EventManager();
    public static class Operations
    {
        public static event EventManager eventLink=null;

        private static void Subscribe()
        {
            eventLink+=new EventManager(Files.Create);
            eventLink+=new EventManager(Files.ReadFile);
            //eventLink+=new EventManager(DefaultUser);
            eventLink+=new EventManager(MainMenu);
            eventLink+=new EventManager(Files.WriteFile);
        }
        /// <summary>
        /// used to trigger the event and start the program
        /// </summary>
        public static void HandleEvent()
        {
            Subscribe();
            eventLink();
        }
        public static  List<UserDetails> userList=new List<UserDetails>();
        public static  List<FoodDetails> foodList=new List<FoodDetails>();
        public static List<OrderDetails> orderList=new List<OrderDetails>();
        public static List<CartItem> cartList=new List<CartItem>();
        public static List<CartItem> tempCartList=new List<CartItem>();
        /// <summary>
        /// MainMenu to display the registartion , login ,exit
        /// Based on the users option the required mathod grt called
        /// </summary>
        public static void MainMenu()
        {
            string choice="yes";
            do{
                System.Console.WriteLine("\n----MainMenu----\n");
                System.Console.WriteLine("Choose the option \n1.UserRegistration \n2.UserLogin  \n3.Exit");
                //option for choosing
                bool temp=int.TryParse(Console.ReadLine(),out int option);
                while(!temp)
                {
                    System.Console.Write("Enter the option in valid format: ");
                    temp=int.TryParse(Console.ReadLine(),out option);
                }
                switch(option)
                {
                    case 1:
                        {
                            System.Console.WriteLine("\n---Registration Called---\n");
                            Registration();
                            break;
                        }
                    case 2:
                        {
                            System.Console.WriteLine("\n----Login called----\n");
                            Login();
                            break;
                        }    
                    case 3:
                        {
                            System.Console.WriteLine("\n---Exiting Menu----\n");
                            choice="no";
                            break;
                        }    
                    default:
                        {
                            System.Console.WriteLine("\n----Invalid Option----\n");
                            break;
                        }    
                }
            }while(choice=="yes");
        }
        /// <summary>
        /// Registration for new user
        /// It get details of the newly registerd user and provide the new userID
        /// </summary>
        public static void Registration()
        {
            System.Console.WriteLine("\n----Registration start----\n");
            System.Console.Write("Enter your Name: ");
            string name=Console.ReadLine();
            System.Console.Write("Enter your FatherName: ");
            string fatherName=Console.ReadLine();
            System.Console.Write("Enter your mobileNumber: ");
            string mobileNumber=Console.ReadLine();
            System.Console.Write("Enter your MailID: ");
            string mailID=Console.ReadLine();
            System.Console.Write("Enter your Gender: ");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.Write("Enter your Workstation Number: ");
            string workstationNumber=Console.ReadLine();
            System.Console.Write("Enter your Balance: ");
            bool temp=double.TryParse(Console.ReadLine(),out double balance);
            while(!temp)
            {
                System.Console.WriteLine("Enter your Balance in valid format");
                temp=double.TryParse(Console.ReadLine(),out balance);
            }
            UserDetails user=new UserDetails(name,fatherName,gender,mobileNumber,mailID,workstationNumber,balance);
            userList.Add(user);
            System.Console.WriteLine("\n---Registration Syccessfull--\n");
            System.Console.WriteLine("Your UserID: "+user.UserID);
        }

        /// <summary>
        /// Based on userID, the login Successfull and the submenu get called
        /// </summary>
        public static void Login() //For get into submenu or invalid userID 
        {
            System.Console.WriteLine("\n---Login start---\n");
            string choice="yes";
            int temp=0;
            do
            {
                System.Console.Write("Enter your UserID: ");
                string userID=Console.ReadLine().ToUpper();
                foreach(UserDetails user in userList)
                {
                    if(userID==user.UserID)
                    {
                        System.Console.WriteLine("\n----Login Successfull----\n");
                        System.Console.WriteLine("\n---Submenu called---\n");
                        Submenu(user);
                        temp=0;
                        choice="no";
                        break;
                    }
                    else
                    {
                        temp=1;
                    }
                }
                if(temp==1)
                {
                    System.Console.WriteLine("\n----Invalid UserID---\n");
                    System.Console.Write("Do you want to continue Login (yes or no): ");
                    choice=Console.ReadLine().ToLower();
                }
            }while(choice=="yes");
        }

        /// <summary>
        /// Submenu displaying the subordinate method of application
        /// Based on userr selection the required method called
        /// </summary>
        /// <param name="user"></param>To access the user registered user
        public static void Submenu(UserDetails user) // For calling the core methods and if option invalid ask user to repeat
        {
            System.Console.WriteLine("\n----Submenu Start----\n");
            string choice="yes";
            do
            {
                System.Console.WriteLine("Choose your option \na.ShowMyProfile  \nb.FoodOrder  \nc.CancelOrder  \nd.OrderHistory   \ne.WalletRecharge   \nf.Exit");
                bool temp=char.TryParse(Console.ReadLine(),out char option);
                while(!temp)
                {
                    System.Console.WriteLine("Enter the option in valid format");
                    temp=char.TryParse(Console.ReadLine(),out option);

                }
                switch(option)
                {
                    case 'a':
                        {
                            System.Console.WriteLine("\n---ShowMyProfile----\n ");
                            ShowMyProfile(user);
                            break;
                        }
                    case 'b':
                        {
                            System.Console.WriteLine("\n-----FoodOrder---\n");
                            FoodOrder(user);
                            break;
                        }    
                    case 'c':
                        {
                            System.Console.WriteLine("\n-----CancelOrder----\n");
                            CancelOrder(user);
                            break;
                        }    
                    case 'd':
                        {
                            System.Console.WriteLine("\n---OrderHistory----\n");
                            OrderHistory(user);
                            break;
                        }    
                    case 'e':  
                        {
                            System.Console.WriteLine("\n-----WalletRecharge---\n");
                            Recharge(user);
                            break;
                        }  
                    case 'f':
                        {
                            System.Console.WriteLine("\n----Exiting Submenu----\n");
                            choice="no";
                            break;
                        }  
                    default:
                        {
                            System.Console.WriteLine("\n----Invalid Option---\n");
                            System.Console.Write("Do you want to continue submenu (yes or no): ");
                            choice=Console.ReadLine().ToLower();
                            break;
                        }    
                }          
            }while(choice=="yes");
        }
        /// <summary>
        /// this method used to display the profile of the logged user
        /// </summary>
        /// <param name="user"></param>
        public static void ShowMyProfile(UserDetails user)
        {
            System.Console.WriteLine("------------------------------------------------------------------------------------");
            System.Console.WriteLine($"|UserID| Name | FatherName |Gender|MobileNumber|MailID|workStationNumber|WalletBalance");
            System.Console.WriteLine("------------------------------------------------------------------------------------");
            foreach(UserDetails tempuser in userList)
            {
                if(user.UserID==tempuser.UserID)
                {
                    System.Console.WriteLine($"|{user.UserID,-6}|{user.Name,-8}|{user.FatherName,-10}|{user.Gender,-6}|:{user.MobileNumber,-11}|{user.MailID,-6}|{user.WorkStationNumber,-5}|{user.WalletBalance}");
                }
            }
        }
        /// <summary>
        /// This method is used to order food as per the customer wish
        /// </summary>
        /// <param name="user"></param>
        public static void FoodOrder(UserDetails user)
        {
            string orderChoice="yes";
            do
            {
            System.Console.WriteLine("|FoodID|FoodName|Price|Available|");
            foreach(FoodDetails food in foodList) //show food details
            {
                 System.Console.WriteLine($"|{food.FoodID,-6}|:{food.FoodName,-8}|{food.FoodPrice,-5}|{food.AvailableQuantity,-9}");
            }
            OrderDetails order=new OrderDetails(user.UserID,DateTime.Now,0,Status.Initiated);
            string choice="yes";
            do
            {
                System.Console.Write("Enter FoodID, That you want to purchase: ");
                string foodID=Console.ReadLine().ToUpper();
                int temp=0;
                foreach(FoodDetails food in foodList)
                {
                    if(foodID==food.FoodID)
                    {
                        System.Console.WriteLine("Food available");
                        string condition="yes";
                        do
                        {
                            System.Console.Write("Enter the required quantity: ");
                            bool temp1=int.TryParse(Console.ReadLine(),out int quantity);
                            while(!temp1)
                            {
                                System.Console.WriteLine("Enter the required quantity in valid format");
                                temp1=int.TryParse(Console.ReadLine(),out quantity);
                            }
                            int flag=0;
                            if(quantity<=food.AvailableQuantity)
                            {
                                System.Console.WriteLine("quantity available");
                                double amount=quantity*food.FoodPrice;
                                food.AvailableQuantity-=quantity;
                                CartItem tempCart=new CartItem(food.FoodID,amount,quantity);
                                tempCartList.Add(tempCart);
                                System.Console.Write("Do you want to pick another order (yes or no): ");
                                orderChoice=Console.ReadLine().ToLower();
                                if(orderChoice=="yes")
                                {
                                    break;
                                }
                                else
                                {
                                    System.Console.WriteLine("You want to confrim the order (yes or no): ");
                                    string ConfrimCondition=Console.ReadLine().ToLower();
                                    if(ConfrimCondition=="no")
                                    {
                                        foreach(CartItem tempcart in tempCartList)
                                        {
                                            if(tempcart.FoodID==food.FoodID)
                                            {
                                                food.AvailableQuantity+=tempCart.OrderQuantity;
                                                break;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        double price=0;
                                       foreach(CartItem tempcart in tempCartList)
                                       {
                                          price+=tempCart.OrderPrice;
                                       }
                                       System.Console.WriteLine("\nTOtal price of your order: "+price+"\n");
                                       string walletChoice="yes";
                                       do
                                       {
                                            if(price>user.WalletBalance)
                                            {
                                                System.Console.WriteLine("\n---Insufficient balance---\n");
                                                System.Console.Write("Do you want to recharge (yes or no): ");
                                                string rechargeChoice=Console.ReadLine().ToLower();
                                                if(rechargeChoice=="no")
                                                {
                                                    System.Console.WriteLine("\nOrder terminated due to Insufficient balance\n");
                                                    food.AvailableQuantity+=quantity;
                                                    break;
                                                }
                                                else
                                                {
                                                    System.Console.Write("Enter the amount to recharge:  ");
                                                    bool temp2=double.TryParse(Console.ReadLine(),out double balance);
                                                    while(!temp2)
                                                    {
                                                        System.Console.WriteLine("Enter the amount to recharge in valid format");
                                                        temp2=double.TryParse(Console.ReadLine(),out balance);
                                                    }
                                                    user.WalletRecharge(user,balance);
                                                    System.Console.WriteLine("WalletBalance after recharge: "+user.WalletBalance);
                                                    walletChoice="yes";
                                                }
                                            }
                                            else
                                            {
                                                System.Console.WriteLine("detuct");
                                                user.WalletBalance-=price;
                                                cartList.AddRange(tempCartList);
                                                foreach(CartItem cart in cartList)
                                                {
                                                    if(cart.OrderID==null)
                                                    {
                                                        cart.OrderID=order.OrderID;
                                                    }
                                                }
                                                order.OrderStatus=Status.Ordered;
                                                order.TotalPrice+=price;
                                                orderList.Add(order);
                                                System.Console.WriteLine("\n----Ordered Successfully---\n");
                                                System.Console.WriteLine("\n---Your OrderID: "+order.OrderID+"\n");
                                                walletChoice="no";
                                            }
                                       }while(walletChoice=="yes");
                                    }
                                }
                                flag=0;
                                condition="no";
                            }
                            else
                            {
                                flag=1;
                            }
                            if(flag==1)
                            {
                                System.Console.WriteLine("\n---Required quantity not available---\n");
                                System.Console.WriteLine($"\n---Quantity available is: {food.AvailableQuantity} \n");
                                System.Console.Write("Do you want to continue (yes or no): ");
                                condition=Console.ReadLine().ToLower();
                            }
                        }while(condition=="yes");
                        temp=0;
                        choice="no";
                        break;
                    }
                    else
                    {
                        temp=1;
                    }
                }
                if(temp==1)
                {
                    System.Console.WriteLine("\n---Invalid foodID---\n");
                    System.Console.Write("Do you want to continue (yes or no): ");
                    choice=Console.ReadLine().ToLower();
                }
            }while(choice=="yes");
        }while(orderChoice=="yes");
    }
        /// <summary>
        /// Based on the customer requirement the particular order get cancelled
        /// </summary>
        /// <param name="user"></param>
         public static void CancelOrder(UserDetails user)
         {
           
            foreach(OrderDetails order in orderList)
            {
                if(user.UserID==order.UserID && order.OrderStatus==Status.Ordered)
                {
                    System.Console.WriteLine($"|OrderID:{order.OrderID}  |UserID:{order.UserID}   |OrderDate:{order.OrderDate.ToString("dd/MM/yyyy")} |TotalPrice:{order.TotalPrice}  |OrderStatus:{order.OrderStatus}");
                }
            }
            string cancelCondition="yes";
            do
            {
                System.Console.Write("Enter the odeerID, That you  want to cancel: ");
                string orderID=Console.ReadLine().ToUpper();
                int temp=0;
                foreach(OrderDetails order in orderList)
                {
                    if(orderID==order.OrderID && order.OrderStatus==Status.Ordered)
                    {
                        System.Console.WriteLine("cancelled start");
                        foreach(CartItem cart in cartList)
                        {

                            if(order.OrderID==cart.OrderID)
                            {
                                foreach(FoodDetails food in foodList)
                                {
                                    if(food.FoodID==cart.FoodID)
                                    {
                                    food.AvailableQuantity+=cart.OrderQuantity;
                                    user.WalletBalance+=order.TotalPrice;
                                    order.OrderStatus=Status.Cancelled;
                                    }
                                }
                            }
                        }
                        System.Console.WriteLine("\nOrder cancelled successfully\n");
                        cancelCondition="no";
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
                    System.Console.WriteLine("\n----InvalidID----\n");
                    System.Console.Write("Do you want to continue cancelling (yes or no): ");
                    cancelCondition=Console.ReadLine().ToLower();
                }
            }while(cancelCondition=="yes");
         }
        /// <summary>
        /// This method is used to display the order history of the user
        /// </summary>
        /// <param name="user"></param>
        public static void OrderHistory(UserDetails user)
        {
            System.Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine($"| Order ID | User ID | Order Date | Total Price | Order Status |");
            System.Console.WriteLine("----------------------------------------------------------");
            foreach(OrderDetails order in orderList)
            {
                if(user.UserID==order.UserID)
                {
                    System.Console.WriteLine($"|{order.OrderID,-10}|{order.UserID,-9}|{order.OrderDate.ToString("dd/MM/yyyy"),-12}|{order.TotalPrice,-13}|{order.OrderStatus,-14}|");
                }
            }
        }
        /// <summary>
        /// This method is used to recharge the wallet balance of the particular user
        /// </summary>
        /// <param name="user"></param>
        public static void Recharge(UserDetails user)
        {
            System.Console.WriteLine("your current walletBalance: "+user.WalletBalance);
            System.Console.Write("Enter amount to recharge: ");
            bool temp=double.TryParse(Console.ReadLine(),out double amount);
            while(!temp)
            {
                System.Console.WriteLine("Enter amount to recharge in valid format");
                temp=double.TryParse(Console.ReadLine(),out amount);
            }
            user.WalletRecharge(user,amount);
            System.Console.WriteLine("WalletBalance After recharge: "+user.WalletBalance);
        }


        public static void DefaultUser()
        {
            UserDetails user1=new UserDetails("RaviChandran","Ettaparajan",Gender.Male,"8857777575","ravi@gmail.com","WS101",400);
            userList.Add(user1);
            UserDetails user2=new UserDetails("Baskaran","Sethurajan",Gender.Male,"9577774774","baskaran@gmail.com","WS105",500);
            userList.Add(user2);

            FoodDetails food1=new FoodDetails("Coffee",20,100);
            foodList.Add(food1);
            FoodDetails food2=new FoodDetails("Tea",15,100);
            foodList.Add(food2);
            FoodDetails food3=new FoodDetails("Biscuit",10,100);
            foodList.Add(food3);
            FoodDetails food4=new FoodDetails("Juice",50,100);
            foodList.Add(food4);
            FoodDetails food5=new FoodDetails("Puff",40,100);
            foodList.Add(food5);
            FoodDetails food6=new FoodDetails("Milk",10,100);
            foodList.Add(food6);
            FoodDetails food7=new FoodDetails("Popcorn",20,10);
            foodList.Add(food7);

            OrderDetails order1=new OrderDetails(user1.UserID,new DateTime(2022,06,15),70,Status.Ordered);
            orderList.Add(order1);
            OrderDetails order2=new OrderDetails(user2.UserID,new DateTime(2022,06,15),100,Status.Ordered);
            orderList.Add(order2);

            CartItem cart1=new CartItem(order1.OrderID,food1.FoodID,20,1);
            cartList.Add(cart1);
            CartItem cart2=new CartItem(order1.OrderID,food3.FoodID,10,1);
            cartList.Add(cart2);
            CartItem cart3=new CartItem(order1.OrderID,food5.FoodID,40,1);
            cartList.Add(cart3);
            CartItem cart4=new CartItem(order2.OrderID,food3.FoodID,10,1);
            cartList.Add(cart4);
            CartItem cart5=new CartItem(order2.OrderID,food4.FoodID,50,1);
            cartList.Add(cart5);
            CartItem cart6=new CartItem(order2.OrderID,food5.FoodID,40,1);
            cartList.Add(cart6);
        }
    }