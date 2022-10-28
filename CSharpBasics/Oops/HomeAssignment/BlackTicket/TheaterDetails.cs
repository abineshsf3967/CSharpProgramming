namespace BlackTicket
{
    /// <summary>
    /// The class is refer to TheaterDetails 
    /// </summary>
    public class TheaterDetails
    {
        private static int s_theaterID=300;
        /// <summary>
        /// It refer the uique TheaterID
        /// </summary>
        /// <value></value>
        public string TheaterID { get; }
        public string TheaterName { get; set; }
        public string TheaterLocation { get; set; }

        public TheaterDetails(string theaterName,string theaterLocation)
        {
            s_theaterID++;
            TheaterID="TID"+s_theaterID;
            TheaterName=theaterName;
            TheaterLocation=theaterLocation;
        }

        public TheaterDetails(string data)
        {
            string[] values=data.Split(',');
            s_theaterID=int.Parse(values[0].Remove(0,3));
            TheaterID=values[0];
            TheaterName=values[1];
            TheaterLocation=values[2];
        }
    }
}