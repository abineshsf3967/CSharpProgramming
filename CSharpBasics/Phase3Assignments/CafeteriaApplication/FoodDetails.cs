namespace CafeteriaApplication
{
    public class FoodDetails
    {
        /// <summary>
        /// Unique ID given for the Food
        /// </summary>
        private static int s_foodID=100;
        /// <summary>
        /// Property FoodID is used to provide the FoodID in the instance of class
        /// </summary>
        /// <value></value>
        public string FoodID { get; }
        /// <summary>
        /// Property FoodName is used to provide the FoodName in the instance of class
        /// </summary>
        /// <value></value>
        public string FoodName { get; set; }
        /// <summary>
        /// Property FoodPrice is used to provide the FoodPrice in the instance of class
        /// </summary>
        /// <value></value>
        public double FoodPrice { get; set; }
        /// <summary>
        /// Property AvailableQuantity is used to provide the AvailableQuantity in the instance of class
        /// </summary>
        /// <value></value>
        public int AvailableQuantity { get; set; }

        /// <summary>
        /// Constructor used to initialize the value for property
        /// </summary>
        /// <param name="foodName"></param>foodName is used to initialize the FoodName property
        /// <param name="foodPrice"></param>foodPrice is used to initialize the FoodPrice property
        /// <param name="availabilityQuantity"></param>availabilityQuantity is used to initialize the AvailabilityQuantity property
        public FoodDetails(string foodName,double foodPrice,int availabilityQuantity)
        {
            s_foodID++;
            FoodID="FID"+s_foodID;
            FoodName=foodName;
            FoodPrice=foodPrice;
            AvailableQuantity=availabilityQuantity;
        }
        /// <summary>
        /// Constructor is used for ReadFile in list
        /// </summary>
        /// <param name="data"></param>
        public FoodDetails(string data)
        {
            string[] values=data.Split(',');
            s_foodID=int.Parse(values[0].Remove(0,3));
            FoodID=values[0];
            FoodName=values[1];
            FoodPrice=double.Parse(values[2]);
            AvailableQuantity=int.Parse(values[3]);
        }
    }
}