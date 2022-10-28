namespace BlackTicket
{
    public enum Status{Default,Booked,Cancelled}
    public class BookingDetails
    {
        private static int s_bookingID=7000;
        public string BookingID { get; }
        public string UserID { get; set; }
        public string MovieID { get; set; }
        public string TheaterID { get; set; }
        public int SeatCount { get; set; }
        public double TotalAmount { get; set; }
        public Status BookingStatus { get; set; }

        public BookingDetails(string userID,string movieID,string theaterID,int seatCount,double totalAmount,Status bookingStatus)
        {
            s_bookingID++;
            BookingID="BID"+s_bookingID;
            UserID=userID;
            MovieID=movieID;
            TheaterID=theaterID;
            SeatCount=seatCount;
            TotalAmount=totalAmount;
            BookingStatus=bookingStatus;
        }

        public BookingDetails(string data)
        {
            string[] values=data.Split(',');
            s_bookingID=int.Parse(values[0].Remove(0,3));
            BookingID=values[0];
            UserID=values[1];
            MovieID=values[2];
            TheaterID=values[3];
            SeatCount=int.Parse(values[4]);
            TotalAmount=double.Parse(values[5]);
            BookingStatus=Status.Parse<Status>(values[6],true);
        }

    }
}