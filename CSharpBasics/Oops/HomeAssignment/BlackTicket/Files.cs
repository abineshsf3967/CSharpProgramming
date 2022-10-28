using System.IO;
namespace BlackTicket
{
    public class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("MovieTicket"))
            {
                System.Console.WriteLine("Create Folder");
                Directory.CreateDirectory("MovieTicket");
            }
            if(!File.Exists("MovieTicket/UserDetails.csv"))
            {
                System.Console.WriteLine("Create File");
                File.Create("MovieTicket/UserDetails.csv");
            }
            if(!File.Exists("MovieTicket/TheaterDetails.csv"))
            {
                System.Console.WriteLine("Create File");
                File.Create("MovieTicket/TheaterDetails.csv");
            }
            if(!File.Exists("MovieTicket/MovieDetails.csv"))
            {
                System.Console.WriteLine("Create File");
                File.Create("MovieTicket/MovieDetails.csv");
            }
            if(!File.Exists("MovieTicket/ScreeningDetails.csv"))
            {
                System.Console.WriteLine("Create File");
                File.Create("MovieTicket/ScreeningDetails.csv");
            }
            if(!File.Exists("MovieTicket/BookingDetails.csv"))
            {
                System.Console.WriteLine("Create File");
                File.Create("MovieTicket/BookingDetails.csv");
            }
        }

        public static void ReadFile()
        {
            string[] users=File.ReadAllLines("MovieTicket/UserDetails.csv");
            foreach(string data in users)
            {
                UserDetails user=new UserDetails(data);
                Operations.userList.Add(user);
            }

            string[] theaters=File.ReadAllLines("MovieTicket/TheaterDetails.csv");
            foreach(string data in theaters)
            {
                TheaterDetails theater=new TheaterDetails(data);
                Operations.theaterList.Add(theater);
            }

            string[] movies=File.ReadAllLines("MovieTicket/MovieDetails.csv");
            foreach(string data in movies)
            {
                MovieDetails movie=new MovieDetails(data);
                Operations.movieList.Add(movie);
            }

            string[] screens=File.ReadAllLines("MovieTicket/ScreeningDetails.csv");
            foreach(string data in screens)
            {
                ScreeningDetails screen=new ScreeningDetails(data);
                Operations.screeningList.Add(screen);
            }

            string[] bookings=File.ReadAllLines("MovieTicket/BookingDetails.csv");
            foreach(string data in bookings)
            {
                BookingDetails booking=new BookingDetails(data);
                Operations.bookList.Add(booking);
            }
        }


        public static void WriteFile()
        {
            string[] userDetails=new string[Operations.userList.Count];
            for(int i=0;i<Operations.userList.Count;i++)
            {
                userDetails[i]=Operations.userList[i].UserID+","+Operations.userList[i].Name+","+Operations.userList[i].Age+","+Operations.userList[i].MobileNumber+","+Operations.userList[i].WalletBalance;
            }
            File.WriteAllLines("MovieTicket/UserDetails.csv",userDetails);

            string[] theaterDetails=new string[Operations.theaterList.Count];
            for(int i=0;i<Operations.theaterList.Count;i++)
            {
                theaterDetails[i]=Operations.theaterList[i].TheaterID+","+Operations.theaterList[i].TheaterName+","+Operations.theaterList[i].TheaterLocation;
            }
            File.WriteAllLines("MovieTicket/TheaterDetails.csv",theaterDetails);

            string[] movieDetails=new string[Operations.movieList.Count];
            for(int i=0;i<Operations.movieList.Count;i++)
            {
                movieDetails[i]=Operations.movieList[i].MovieID+","+Operations.movieList[i].MovieName+","+Operations.movieList[i].Language;
            }
            File.WriteAllLines("MovieTicket/MovieDetails.csv",movieDetails);

            string[] screeningDetails=new string[Operations.screeningList.Count];
            for(int i=0;i<Operations.screeningList.Count;i++)
            {
                screeningDetails[i]=Operations.screeningList[i].MovieID+","+Operations.screeningList[i].TheaterID+","+Operations.screeningList[i].NoOfSeatsAvailable+","+Operations.screeningList[i].TicketPrice;
            }
            File.WriteAllLines("MovieTicket/ScreeningDetails.csv",screeningDetails);

            string[] bookingDetails=new string[Operations.bookList.Count];
            for(int i=0;i<Operations.bookList.Count;i++)
            {
                bookingDetails[i]=Operations.bookList[i].BookingID+","+Operations.bookList[i].UserID+","+Operations.bookList[i].MovieID+","+Operations.bookList[i].TheaterID+","+Operations.bookList[i].SeatCount+","+Operations.bookList[i].TotalAmount+","+Operations.bookList[i].BookingStatus;
            }
            File.WriteAllLines("MovieTicket/BookingDetails.csv",bookingDetails);
        }
    }
}