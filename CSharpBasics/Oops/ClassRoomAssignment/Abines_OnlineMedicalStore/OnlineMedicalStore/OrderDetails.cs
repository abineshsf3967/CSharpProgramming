using System;
/// <summary>
/// namespace is declared as OnlineMedical Store
/// UserDetails class include in the namespace
/// </summary>
namespace OnlineMedicalStore
{
    public enum OrderStatus{Default,Purchased,Cancelled}
    /// <summary>
    /// OrderDetails class contains propety of user
    /// </summary>
    public class OrderDetails
    {
        /// <summary>
        /// it is a unique ID for Order
        /// </summary>
        private static int s_orderID=2000;
        /// <summary>
        /// It is a unique OrderID which displayed to the user
        /// </summary>
        /// <value></value>
        public string OrderID { get;  }
        /// <summary>
        ///It is a unique userID which displayed to the user
        /// </summary>
        /// <value></value>
        public string UserID { get; set; }
        /// <summary>
        ///  It is a unique medicineID which displayed to the user
        /// </summary>
        /// <value></value>
        public string MedicineID { get; set; }
        /// <summary>
        /// MedicineCount represent the MedicineCount of the individual medicine
        /// </summary>
        /// <value></value>
        public int MedicineCount { get; set; }
        /// <summary>
        /// TotalPrice represent the TotalPrice of the individual medicine
        /// </summary>
        /// <value></value>
        public double TotalPrice { get; set; }
        /// <summary>
        /// OrderDate represent the OrderDate of the individual medicine
        /// </summary>
        /// <value></value>
        public DateTime OrderDate { get; set; }
        /// <summary>
        /// Orderstatus represent the Orderstatus of the individual medicine
        /// </summary>
        /// <value></value>
        public OrderStatus Orderstatus { get; set; }

        /// <summary>
        /// Constructor named as OrderDetails ref>="OrderDetails class"
        /// </summary>
        /// <param name="userID"></param>userID is assigned to the property userID
        /// <param name="medicineID"></param>medicineID is assigned to the property medicineID
        /// <param name="medicineCount"></param>medicineCoun is assigned to the property medicineCoun
        /// <param name="totalPrice"></param>totalPrice" is assigned to the property totalPrice"
        /// <param name="orderDate"></param>orderDateis assigned to the property orderDate
        /// <param name="orderStatus"></param>orderStatus is assigned to the property orderStatus
        public OrderDetails(string userID,string medicineID,int medicineCount,double totalPrice,DateTime orderDate,OrderStatus orderStatus )
        {
            s_orderID++;
            OrderID="OID"+s_orderID;
            UserID=userID;
            MedicineID=medicineID;
            MedicineCount=medicineCount;
            TotalPrice=totalPrice;
            OrderDate=orderDate;
            Orderstatus=orderStatus;
        }
        
    }
}