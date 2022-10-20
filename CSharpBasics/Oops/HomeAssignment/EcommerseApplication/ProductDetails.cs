namespace EcommerseApplication
{
    public class ProductDetails
    {
        private static int s_productID=100;
        public string ProductID { get; set; }
        public string ProductName { get;  }
        public double Price { get; set; }
        public int Stock { get; set; }
        public int ShippingDuration { get; set; }



        public ProductDetails(string productName,double price,int stock,int shippingDuration)
        {
            s_productID++;
            ProductID="PID"+s_productID;
            ProductName=productName;
            Price=price;
            Stock=stock;
            ShippingDuration=shippingDuration;
        }
        
        
        
        
        
        
        
        
    }
}