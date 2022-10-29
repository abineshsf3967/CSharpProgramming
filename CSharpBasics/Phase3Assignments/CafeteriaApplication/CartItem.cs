namespace CafeteriaApplication
{
    public class CartItem
    {
        /// <summary>
        /// Unique ID given for the CartItem
        /// </summary>
        private static int s_itemID=100;
        /// <summary>
        /// Property ItemID is used to provide the ItemID in the instance of class
        /// </summary>
        /// <value></value>
        public string ItemID { get;}
        /// <summary>
        /// Property OrderID is used to provide the OrderID in the instance of class
        /// </summary>
        /// <value></value>
        public string OrderID { get; set; }
        /// <summary>
        /// Property FoodID is used to provide the FoodID in the instance of class
        /// </summary>
        /// <value></value>
        public string FoodID { get; set; }
        /// <summary>
        /// Property OrderPrice is used to provide the OrderPrice in the instance of class
        /// </summary>
        /// <value></value>
        public double OrderPrice { get; set; }
        /// <summary>
        /// Property OrderQuantity is used to provide the OrderQuantity in the instance of class
        /// </summary>
        /// <value></value>
        public int OrderQuantity { get; set; }

        /// <summary>
        /// Constructor used to initialize the value for property
        /// </summary>
        /// <param name="orderID"></param>orderID is used to initialize the OrderID property
        /// <param name="foodID"></param>foodID is used to initialize the FoodID property
        /// <param name="orderPrice"></param>orderPrice is used to initialize the OrderPrice property
        /// <param name="orderQuantity"></param>orderQuantity is used to initialize the OrderQuantity property
        public CartItem(string orderID,string foodID,double orderPrice,int orderQuantity)
        {
            s_itemID++;
            ItemID="ITID"+s_itemID;
            OrderID=orderID;
            FoodID=foodID;
            OrderPrice=orderPrice;
            OrderQuantity=orderQuantity;
        }
        /// <summary>
        /// Constructor is used for ReadFile in list
        /// </summary>
        /// <param name="data"></param>
        public CartItem(string data)
        {
            string[] values=data.Split(',');
            s_itemID=int.Parse(values[0].Remove(0,4));
            ItemID=values[0];
            OrderID=values[1];
            FoodID=values[2];
            OrderPrice=int.Parse(values[3]);
            OrderQuantity=int.Parse(values[4]);
        }
        public CartItem(string foodID,double orderPrice,int orderQuantity)
        {
            s_itemID++;
            ItemID="ITID"+s_itemID;
            FoodID=foodID;
            OrderPrice=orderPrice;
            OrderQuantity=orderQuantity;
        }
    }
}