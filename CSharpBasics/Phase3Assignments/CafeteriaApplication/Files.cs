using System.IO;
namespace CafeteriaApplication
{
    public static class Files
    {
        /// <summary>
        /// Used to create the directory and file
        /// </summary>
        public static void Create()
        {
            if(!Directory.Exists("Cafeteria"))
            {
                System.Console.WriteLine("Create Directory");
                Directory.CreateDirectory("Cafeteria");
            }
            if(!File.Exists("Cafeteria/UserDetails.csv"))
            {
                System.Console.WriteLine("Create File");
                File.Create("Cafeteria/UserDetails.csv");
            }
            if(!File.Exists("Cafeteria/FoodDetails.csv"))
            {
                System.Console.WriteLine("Create File");
                File.Create("Cafeteria/FoodDetails.csv");
            }
            if(!File.Exists("Cafeteria/OrderDetails.csv"))
            {
                System.Console.WriteLine("Create File");
                File.Create("Cafeteria/OrderDetails.csv");
            }
            if(!File.Exists("Cafeteria/CartItem.csv"))
            {
                System.Console.WriteLine("Create File");
                File.Create("Cafeteria/CartItem.csv");
            }
        }
        /// <summary>
        /// Method used to Read data from the list
        /// </summary>
        public static void ReadFile()
        {
            string[] users=File.ReadAllLines("Cafeteria/UserDetails.csv");
            foreach(string data in users)
            {
                UserDetails user=new UserDetails(data);
                Operations.userList.Add(user);
            }
            string[] foods=File.ReadAllLines("Cafeteria/FoodDetails.csv");
            foreach(string data in foods)
            {
                FoodDetails food=new FoodDetails(data);
                Operations.foodList.Add(food);
            }
            string[] orders=File.ReadAllLines("Cafeteria/OrderDetails.csv");
            foreach(string data in orders)
            {
                OrderDetails order=new OrderDetails(data);
                Operations.orderList.Add(order);
            }
            string[] carts=File.ReadAllLines("Cafeteria/CartItem.csv");
            foreach(string data in carts)
            {
                 CartItem cart=new CartItem(data);
                Operations.cartList.Add(cart);
            }
        }
        /// <summary>
        /// Method use to write the data on the csv file
        /// </summary>
        public static void WriteFile()
        {
            string[] userDetail=new string[Operations.userList.Count];
            for(int i=0;i<Operations.userList.Count;i++)
            {
                userDetail[i]=Operations.userList[i].UserID+","+Operations.userList[i].Name+","+Operations.userList[i].FatherName+","+Operations.userList[i].Gender+","+Operations.userList[i].MobileNumber+","+Operations.userList[i].MailID+","+Operations.userList[i].WorkStationNumber+","+Operations.userList[i].WalletBalance;
            }
            File.WriteAllLines("Cafeteria/UserDetails.csv",userDetail);

            string[] foodDetail=new string[Operations.foodList.Count];
            for(int i=0;i<Operations.foodList.Count;i++)
            {
                foodDetail[i]=Operations.foodList[i].FoodID+","+Operations.foodList[i].FoodName+","+Operations.foodList[i].FoodPrice+","+Operations.foodList[i].AvailableQuantity;
            }
            File.WriteAllLines("Cafeteria/FoodDetails.csv",foodDetail);

            string[] orderDetail=new string[Operations.orderList.Count];
            for(int i=0;i<Operations.orderList.Count;i++)
            {
                orderDetail[i]=Operations.orderList[i].OrderID+","+Operations.orderList[i].UserID+","+Operations.orderList[i].OrderDate.ToString("dd/MM/yyyy")+","+Operations.orderList[i].TotalPrice+","+Operations.orderList[i].OrderStatus;
            }
            File.WriteAllLines("Cafeteria/OrderDetails.csv",orderDetail);

            string[] cartItem=new string[Operations.cartList.Count];
            for(int i=0;i<Operations.cartList.Count;i++)
            {
                cartItem[i]=Operations.cartList[i].ItemID+","+Operations.cartList[i].OrderID+","+Operations.cartList[i].FoodID+","+Operations.cartList[i].OrderPrice+","+Operations.cartList[i].OrderQuantity;
            }
            File.WriteAllLines("Cafeteria/CartItem.csv",cartItem);
        }
    }
}