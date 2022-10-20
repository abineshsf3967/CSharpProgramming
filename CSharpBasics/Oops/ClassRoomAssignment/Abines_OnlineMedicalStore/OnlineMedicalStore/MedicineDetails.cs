using System;
/// <summary>
/// namespace is declared as OnlineMedical Store
/// UserDetails class include in the namespace
/// </summary>
namespace OnlineMedicalStore
{
    /// <summary>
    /// MedicineDetails class contains propety of user
    /// </summary>
    public class MedicineDetails
    {
        /// <summary>
        /// it is a unique ID for medicine
        /// </summary>
        private static int s_medicineID=100;
        /// <summary>
        /// It is a unique medicineID which displayed to the user
        /// </summary>
        /// <value></value>
        public string MedicineID { get;  }
        /// <summary>
        /// MedicineName represent the age of the individual medicine
        /// </summary>
        /// <value></value>
        public string MedicineName { get; set; }
        /// <summary>
        /// AvailabilityCount represent the AvailabilityCount of the individual medicine
        /// </summary>
        /// <value></value>
        public int AvailabilityCount { get; set; }
        /// <summary>
        /// Price represent the Price of the individual medicine
        /// </summary>
        /// <value></value>
        public double Price { get; set; }
        /// <summary>
        /// DateOfExpiry represent the DateOfExpiry of the individual medicine
        /// </summary>
        /// <value></value>
        public DateTime DateOfExpiry { get; set; }

        /// <summary>
        /// Constructor named as MedcicineDetails ref>="MedicineDetails class"
        /// </summary>
        /// <param name="medicineName"></param>medicineName is assigned to the property MedicineName
        /// <param name="availabilityCount"></param>availabilityCount is assigned to the property AvailabilityCount
        /// <param name="price"></param>price is assigned to the property Price
        /// <param name="dateOfExpiry"></param>dateOfExpiry is assigned to the property DateOfExpiry
        public MedicineDetails(string medicineName,int availabilityCount,double price,DateTime dateOfExpiry)
         {
            s_medicineID++;
            MedicineID="MD"+s_medicineID;
            MedicineName=medicineName;
            AvailabilityCount=availabilityCount;
            Price=price;
            DateOfExpiry=dateOfExpiry;
         }

    }
}