using System;
namespace CafeteriaApplication
{
    public enum Status{Default,Initiated,Ordered,Cancelled}
    public class OrderDetails
    {
        /// <summary>
        /// Unique ID given for the Order
        /// </summary>
        private static int s_orderID=1000;
        /// <summary>
        /// Property OrderID is used to provide the OrderID in the instance of class
        /// </summary>
        /// <value></value>
        public string OrderID { get;}
        /// <summary>
        /// Property UserID is used to provide the UserID in the instance of class
        /// </summary>
        /// <value></value>
        public string UserID { get; set; }
        /// <summary>
        /// Property OrderDate is used to provide the OrderDate in the instance of class
        /// </summary>
        /// <value></value>
        public DateTime OrderDate { get; set; }
        /// <summary>
        /// Property TotalPrice is used to provide the TotalPrice in the instance of class
        /// </summary>
        /// <value></value>
        public double TotalPrice { get; set; }
        /// <summary>
        /// Property OrderStatus is used to provide the OrderStatus in the instance of class
        /// </summary>
        /// <value></value>
        public Status OrderStatus { get; set; }
        /// <summary>
        /// Constructor used to initialize the value for property
        /// </summary>
        /// <param name="userID"></param>UserID is used to initialize the UserID property
        /// <param name="orderDate"></param>orderDate is used to initialize the OrderDate property
        /// <param name="totalPrice"></param>totalPrice is used to initialize the TotalPrice property
        /// <param name="orderStatus"></param>orderStatus is used to initialize the OrderStatus property
        public OrderDetails(string userID,DateTime orderDate,double totalPrice,Status orderStatus)
        {
            s_orderID++;
            OrderID="OID"+s_orderID;
            UserID=userID;
            OrderDate=orderDate;
            TotalPrice=totalPrice;
            OrderStatus=orderStatus;
        }
        /// <summary>
        /// Constructor is used for ReadFile in list
        /// </summary>
        /// <param name="data"></param>
        public OrderDetails(string data)
        {
            string[] values=data.Split(',');
            s_orderID=int.Parse(values[0].Remove(0,3));
            OrderID=values[0];
            UserID=values[1];
            OrderDate=DateTime.ParseExact(values[2],("dd/MM/yyyy"),null);
            TotalPrice=double.Parse(values[3]);
            OrderStatus=Enum.Parse<Status>(values[4],true);
        }
    }
}