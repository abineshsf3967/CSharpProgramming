using System;
using System.Collections.Generic;
namespace EcommerseApplication;

    public static class Operations
    {
        public static List<CustomerDetails> customerList=new List<CustomerDetails>();
        public static List<ProductDetails> productList=new List<ProductDetails>();
        public static List<OrderDetails> orderList=new List<OrderDetails>();
        
        public static void Mainmenu()
        {
            string choice="yes";
            do
            {
                System.Console.WriteLine("\n   MainMenu  \n");
                System.Console.WriteLine("Choose your Option \n1.CustomerRegistration \n2.Login and Purchase \n3.Exit");
                System.Console.Write("Enter your option:");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        {
                            System.Console.WriteLine("\n   Registration Called   \n");
                            CustomerRegistration();
                            break;
                        }
                    case 2:
                        {
                            System.Console.WriteLine("\n   Login Called  \n");
                            LoginAndPurchase();
                            break;
                        }      
                    case 3:
                        {
                            System.Console.WriteLine("\n   Exiting MainMenu   \n");
                            choice="no";
                            break;
                        }      
                }
            }while(choice=="yes");
        }

        public static void CustomerRegistration()
        {
            System.Console.WriteLine("   Registartion start   ");
            System.Console.WriteLine("Enter your Name: ");
            string customerName=Console.ReadLine();
            System.Console.WriteLine("Enter your city: ");
            string city=Console.ReadLine();
            System.Console.WriteLine("Enter your MobileNumber: ");
            long mobileNumber=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your MailID: ");
            string mailID=Console.ReadLine();
            System.Console.WriteLine("Ener your walletBalance: ");
            double walletBalance=double.Parse(Console.ReadLine());
            CustomerDetails customer=new CustomerDetails(customerName,city,mobileNumber,walletBalance,mailID);
            customerList.Add(customer);
            System.Console.WriteLine("   Successful Registration   ");
            System.Console.WriteLine("\n    Your CustomerID: "+customer.CustomerID+"\n");
        }

        public static void LoginAndPurchase()
        {
            int temp=0;
            System.Console.Write("Enter your CustomerID: ");
            string customerID=Console.ReadLine().ToUpper();
            foreach(CustomerDetails customer in customerList)
            {
                if(customerID==customer.CustomerID)
                {
                    System.Console.WriteLine("\n   Successful Login   \n");
                    SubMenu(customer);
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
                System.Console.WriteLine("\n   Invalid CustomeID   \n");
            }
        }

        public static void SubMenu(CustomerDetails customer)
        {
            string choice="yes";
            do
            {
                System.Console.WriteLine("\n  SubMenu   \n");
                System.Console.WriteLine("Choose your option \n1.Purchase \n2.OrderHistory \n3.CancelOrder \n4.WallletBalance \n5.Exit");
                System.Console.Write("your option: ");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        {
                            System.Console.WriteLine("\n   purchase   \n");
                            Purchase(customer);
                            break;
                        }
                    case 2:
                        {
                            System.Console.WriteLine("\n    OrderHistory   \n");
                            OrderHistory(customer);
                            break;
                        }    
                    case 3:
                        {
                            System.Console.WriteLine("\n    CancelOrder   \n");
                            CancelOrder(customer);
                            break;
                        }    
                    case 4:
                        {
                            System.Console.WriteLine("\n   WalletBalance   \n");
                            WalletBalance(customer);
                            break;
                        }     
                    case 5:
                        {
                            System.Console.WriteLine("\n   Exit from Submenu   \n");
                            choice="no";
                            break;
                        }     
                }
            }while(choice=="yes");
        }
        
        public static void DefaultUser()
        {
            //CustomerDetails
            CustomerDetails customer1=new CustomerDetails("Ravi","Chennai",9885858588,50000,"ravi@gamil.com");
            customerList.Add(customer1);
            CustomerDetails customer2=new CustomerDetails("Baskaran","chennai",98884757575,60000,"baskaran@gamil.com");
            customerList.Add(customer2);
        
            //ProductDetails
            ProductDetails product1=new ProductDetails("Mobile",10000,10,3);
            productList.Add(product1);
            ProductDetails product2=new ProductDetails("Tablet",15000,5,2);
            productList.Add(product2);
            ProductDetails product3=new ProductDetails("Camera",20000,3,4);
            productList.Add(product3);
            ProductDetails product4=new ProductDetails("IPhone",50000,5,6);
            productList.Add(product4);
            ProductDetails product5=new ProductDetails("Laptop",40000,3,3);
            productList.Add(product5);
            
            //OrderDetails
            OrderDetails order1=new OrderDetails(customer1.CustomerID,product1.ProductID,20000,DateTime.Now,2,OrderStatus.Booked);
            orderList.Add(order1);
            OrderDetails order2=new OrderDetails(customer2.CustomerID,product2.ProductID,40000,DateTime.Now,2,OrderStatus.Booked);
            orderList.Add(order2);
        }

        public static void Purchase(CustomerDetails customer)
        {
            System.Console.WriteLine("|ProductID|ProductName|ProductPrice|ProductStock|ProductShippingDuration|");
            foreach(ProductDetails product in productList)
            {
                System.Console.WriteLine($"{product.ProductID}|{product.ProductName}|{product.Price}|{product.Stock}|{product.ShippingDuration}");
            }
            System.Console.Write("Enter the productID for the product which you want: ");
            string productID=Console.ReadLine();
            int temp=0;
            foreach(ProductDetails product in productList)
            {
                if(productID==product.ProductID)
                {
                    System.Console.WriteLine("Valid ID");
                    System.Console.WriteLine("How much count do you want: ");
                    int count=int.Parse(Console.ReadLine());
                    int flag=0;
                    if(count<product.Stock)
                    {
                         System.Console.WriteLine("Available");
                         int deliveryCharge=50;
                         double totalAmount=(count*product.Price)+deliveryCharge;
                         System.Console.WriteLine("Total Amount: "+"\n");
                         if(totalAmount>customer.WalletBalance)
                         {
                             System.Console.WriteLine("Insufficient walletBalance");
                         }
                         else
                         {
                            customer.WalletBalance-=totalAmount;
                            product.Stock-=count;
                            System.Console.WriteLine("  Order Confrimed  ");
                            OrderDetails order = new OrderDetails(customer.CustomerID,product.ProductID,totalAmount,DateTime.Now,count,OrderStatus.Booked);
                            orderList.Add(order);
                            System.Console.WriteLine("Your OrderID: "+order.OrderID);
                            foreach(OrderDetails order1 in orderList)
                            {
                               if(order1.ProductID==product.ProductID)
                               {
                                System.Console.WriteLine("Delivery Date: "+(DateTime.Now).AddDays(product.ShippingDuration).ToString(@"dd/MM/yyyy"));
                                break;
                               }
                            }
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
                        System.Console.WriteLine("   Required count is not available  ");
                        System.Console.WriteLine("Current availability: "+product.Stock);
                        temp=0;
                    }
                    break;
                }
                else
                {
                    temp=1;
                }
            }
            if(temp==1)
            {
                System.Console.WriteLine("\n   Invalid ID   \n");
            }
        }

        public static void OrderHistory(CustomerDetails customer)
        {
            System.Console.WriteLine("|OrderID|CustomerID|TotalPrice|PurchaseDate|Quantity|OrderStatus|");
            foreach(OrderDetails order in orderList)
            {
                if(order.CustomerID==customer.CustomerID)
                {
                    System.Console.WriteLine($"|{order.OrderID}|{order.CustomerID}|{order.TotalPrice}|{order.PurchaseDate.ToString("dd/MM/yyyy")}|{order.Quantity}|{order.OrderStatus}|");
                }
            }
        }
        public static void CancelOrder(CustomerDetails customer)
        {
            OrderHistory(customer);
            System.Console.WriteLine("which order do ypu want to cancel , Enter orderID: ");
            string orderID=Console.ReadLine();
            foreach(OrderDetails order in orderList)
            {
                if(orderID==order.OrderID)
                {
                    order.OrderStatus=OrderStatus.Cancelled;
                    System.Console.WriteLine("Order cancelled");
                    foreach(ProductDetails product in productList)
                    {
                          if(order.ProductID==product.ProductID)
                          {
                            product.Stock+=order.Quantity;
                             if(order.CustomerID==customer.CustomerID)
                            {
                            customer.WalletBalance+=order.TotalPrice;
                             }
                          } 
                         
                    }
                }
            } 
        }

        public static void WalletBalance(CustomerDetails customer)
        {
            System.Console.WriteLine("Wallet balance : "+customer.WalletBalance);
            System.Console.WriteLine("You wish to recharge the wallet(yes or no):");
            string choice=Console.ReadLine().ToLower();
            if(choice=="yes")
            {
                System.Console.WriteLine("how much do you want to add: ");
                double amount=double.Parse(Console.ReadLine());
                customer.WalletBalance+=amount;
                System.Console.WriteLine("your updated walletBalance: "+customer.WalletBalance);
            }
        }
    }