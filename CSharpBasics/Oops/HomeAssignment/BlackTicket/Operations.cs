using System;
namespace BlackTicket
{
    public delegate void EventManager();
    public static class Operations
    {
        public static event EventManager eventlink=null;
        private static void Subscribe()
        {
            eventlink+=new EventManager(Files.Create);
           // eventlink+=new EventManager(Files.ReadFile);
            eventlink+=new EventManager(DefaultUser);
            eventlink+=new EventManager(MainMenu);
            eventlink+=new EventManager(Files.WriteFile);
        }

        public static void HandleEvent()
        {
            Subscribe();
            eventlink();
        }
        public static List<UserDetails> userList=new List<UserDetails>();
        public static List<TheaterDetails> theaterList=new List<TheaterDetails>();
        public static List<MovieDetails> movieList=new List<MovieDetails>();
        public static List<ScreeningDetails> screeningList=new List<ScreeningDetails>();
        public static List<BookingDetails> bookList=new List<BookingDetails>();
        public static void MainMenu()
        {
            string choice="yes";
            do
            {
                System.Console.WriteLine("\n-----MainMenu---- \n");
                System.Console.WriteLine("Choose your Option \n1.UserRegistration \n2.Login  \n3.Exit");
                bool temp=int.TryParse(Console.ReadLine(),out int option);
                while(!temp)
                {
                    System.Console.Write("Enter the option in valid format: ");
                    temp=int.TryParse(Console.ReadLine(),out option);
                }
                switch(option)
                {
                    case 1:
                        {
                            System.Console.WriteLine("----Registration Called----");
                            UserRegistration();
                            break;
                        }
                    case 2:
                        {
                            System.Console.WriteLine("---Login Called---");
                            Login();
                            break;
                        }    
                    case 3:
                        {
                            System.Console.WriteLine("---Exiting Menu---");
                            choice="no";
                            break;
                        }    
                    default:
                        {
                            System.Console.WriteLine("----Invalid option----\n Enter the valid Option");
                            break;
                        }    
                }
            }while(choice=="yes");
        }

        public static void UserRegistration()
        {
            System.Console.WriteLine("\n----Registration Form---");
            System.Console.Write("Enter your Name: ");
            string name=Console.ReadLine();
            System.Console.Write("Enter your Age: ");
            bool temp=int.TryParse(Console.ReadLine(),out int age);
            while(!temp)
            {
                System.Console.WriteLine("Enter your Age in valid format:");
                temp=int.TryParse(Console.ReadLine(),out age);
            }
            System.Console.Write("Enter your MobileNumber: ");
            string mobileNumber=Console.ReadLine();
            System.Console.Write("Enter your Wallet Balance: ");
            bool temp1=double.TryParse(Console.ReadLine(),out double walletBalance);
            while(!temp1)
            {
                System.Console.Write("Enter your Wallet Balance in valid format: ");
                temp1=double.TryParse(Console.ReadLine(),out walletBalance);
            }
            UserDetails user=new UserDetails(name,age,mobileNumber,walletBalance);
            userList.Add(user);
            System.Console.WriteLine("\n-----Registration Successfull---\n");
            System.Console.WriteLine("\n--Your UserID: "+user.UserID);
        }


        public static void Login()
        {
            string choice="yes";
            do
            {
                System.Console.WriteLine("\n----Login Menu---\n");
                System.Console.Write("Enter your UserID: ");
                string userID=Console.ReadLine().ToUpper();
                int temp=0;
                foreach(UserDetails user in userList)
                {
                    if(userID==user.UserID)
                    {
                        System.Console.WriteLine("\n---Successfull Login---\n");
                        System.Console.WriteLine("---SubMenu Called----");
                        SubMenu(user);
                        temp=0;
                        choice="no";
                        break;
                    }
                    else
                    {
                        temp=1;
                    }
                }
                if(temp==1)
                {
                    System.Console.WriteLine("\n----Invalid UserID----\n");
                    System.Console.WriteLine("Do you want to continue login (yes or no): ");
                    choice=Console.ReadLine().ToLower();
                }
            }while(choice=="yes");    
        }


        public static void SubMenu(UserDetails user)
        {
            string choice="yes";
            do
            {
                System.Console.WriteLine("\n----SubMenu Start----\n");
                //Submenu Option displaying
                System.Console.WriteLine("Choose the option \na.TicketBooking \nb.TicketCancellation \nc.BookingHistory  \nd.WalletRecharge \ne.Exit");
                bool temp=char.TryParse(Console.ReadLine(),out char option);
                while(!temp)
                {
                    System.Console.Write("Enter the option in valid format: ");
                    temp=char.TryParse(Console.ReadLine(),out option);
                }
                //Choosing option in switch case
                switch(option)
                {
                    //callig the methods
                    case 'a':
                        {
                            System.Console.WriteLine("----TicketBooking----");
                            TicketBooking(user);
                            break;
                        }
                    case 'b':
                        {
                            System.Console.WriteLine("----TicketCancellation----");
                            TicketCancellation(user);
                            break;
                        }    
                    case 'c':
                        {
                            System.Console.WriteLine("---Booking History---");
                            BookingHistory(user);  
                            break;
                        }    
                    case 'd':
                        {
                            System.Console.WriteLine("---WalletRecharge---");
                            WalletRecharge(user);
                            break;
                        }    
                    case 'e':
                        {
                            System.Console.WriteLine("----Exit------");
                            choice="no";
                            break;
                        }    
                    default:
                        {
                            System.Console.WriteLine("\n----Invalid Option----\n");
                            System.Console.WriteLine("Enter the vaild option");
                            break;
                        }    
                }
            }while(choice=="yes");
            
        }


        public static void TicketBooking(UserDetails user)
        {
            //Showing the theater Details
            System.Console.WriteLine("--------------------------------------");
            System.Console.WriteLine("|TheaterID|TheaterName|TheaterLocation|");
            System.Console.WriteLine("--------------------------------------");
             foreach(TheaterDetails tempTheater in theaterList)
            {
                System.Console.WriteLine($"|{tempTheater.TheaterID, -9}|{tempTheater.TheaterName,-11}|{tempTheater.TheaterLocation,-15}");
            }
            //Ask user to select theater ID
            string theaterCondition="yes";
            do
            {
                System.Console.Write("Enter the theaterID, Which you want to book: ");
                string theaterID=Console.ReadLine().ToUpper();
                //check theater ID
                int temp=0;
                foreach(TheaterDetails tempTheater in theaterList)
                {
                    if(theaterID==tempTheater.TheaterID)
                    {
                        System.Console.WriteLine("theater Available");
                        System.Console.WriteLine("-------------------------------");
                        System.Console.WriteLine("|MovieID||MovieName      |Language|");
                        System.Console.WriteLine("-------------------------------");
                        foreach(ScreeningDetails tempScreen  in screeningList)
                        {
                        if(tempTheater.TheaterID==tempScreen.TheaterID)
                        {
                            foreach(MovieDetails tempMovie in movieList)
                            {
                                //Showing movie details of required theater
                                if(tempScreen.MovieID==tempMovie.MovieID)
                                {
                                    System.Console.WriteLine($"{tempMovie.MovieID,-7}|{tempMovie.MovieName,-9}|{tempMovie.Language,-16}");
                                }    
                            }   
                        }
                        }
                        //Choosing MovieID from movieList
                            string choice="yes";
                            do
                            {
                                System.Console.Write("Select the movieID, that you want: ");
                                string movieID=Console.ReadLine().ToUpper();
                                int check=0;
                                foreach(MovieDetails tempMovie in movieList)
                                {
                                    if(movieID==tempMovie.MovieID)
                                    {
                                        
                                        System.Console.WriteLine("Valid MovieID");
                                        string condition="yes";
                                        do
                                        {
                                        System.Console.Write("Enter the seats count: ");
                                        bool temp1=int.TryParse(Console.ReadLine(),out int seatCount);
                                        while(!temp1)
                                        {
                                            System.Console.Write("Enter the seats count in valid format: ");
                                            temp1=int.TryParse(Console.ReadLine(),out seatCount);
                                        }
                                        int flag=0;
                                        foreach(ScreeningDetails screen in screeningList)
                                        {
                                            if(seatCount>screen.NoOfSeatsAvailable)
                                            {
                                                System.Console.WriteLine($"Available seat count is: {screen.NoOfSeatsAvailable}");
                                                System.Console.Write("Do you want to continue the booking (yes or no): ");
                                                condition=Console.ReadLine().ToLower();
                                                flag=0;
                                                break;
                                            }
                                            else if(seatCount<=screen.NoOfSeatsAvailable)
                                            {
                                                System.Console.WriteLine("Seat Available");
                                                double totalWithOutTax=(seatCount*screen.TicketPrice);
                                                double totalPrice=totalWithOutTax+(0.18/totalWithOutTax);
                                                string walletCondition="yes";
                                                do
                                                {
                                                    if(totalPrice>user.WalletBalance)
                                                    {
                                                        System.Console.WriteLine("\n----insufficient Balance---\n");
                                                        System.Console.WriteLine("Please recharge the wallet");
                                                        System.Console.WriteLine("enter the amount to recharge: ");
                                                        bool temp2=double.TryParse(Console.ReadLine(),out double amount);
                                                        while(!temp2)
                                                        {
                                                            System.Console.WriteLine("enter the amount to recharge in valid ");
                                                            temp2=double.TryParse(Console.ReadLine(),out amount);

                                                        }
                                                        user.RechargeWallet(user,amount);
                                                        walletCondition="yes";


                                                    }
                                                    else
                                                    {
                                                        System.Console.WriteLine("Detuct");
                                                        user.WalletBalance-=totalPrice;
                                                        screen.NoOfSeatsAvailable-=seatCount;
                                                        BookingDetails book =new BookingDetails(user.UserID,tempMovie.MovieID,tempTheater.TheaterID,seatCount,totalPrice,Status.Booked);
                                                        bookList.Add(book);
                                                        System.Console.WriteLine("\n----Booking successfull----\n");
                                                        System.Console.WriteLine("Your Booking ID: "+book.BookingID);
                                                        walletCondition="no";
                                                    }
                                                }while(walletCondition=="yes");  
                                                flag=0;
                                                condition="no";
                                                break;
                                            }
                                            else
                                            {
                                                flag=1;
                                            }
                                        }
                                        if(flag==1)
                                        {
                                            System.Console.WriteLine("Invalid answer");
                                        }
                                        }while(condition=="yes");
                                        check=0;
                                        choice="no";
                                        break;
                                    }
                                    else
                                    {
                                        check=1;
                                    }
                                }
                                if(check==1)
                                {
                                    System.Console.WriteLine("---Invalid ID---");
                                    System.Console.Write("Do you want continue booking (yes or no): ");
                                    choice=Console.ReadLine().ToLower();
                                }

                            }while(choice=="yes");
                        temp=0;
                        theaterCondition="no";
                        break;
                    }
                    else
                    {
                        temp=1;
                    }
                }
                if(temp==1)
                {
                    System.Console.WriteLine("---Invalid TheaterID---");
                    System.Console.Write("Do you want continue booking (yes or no): ");
                    theaterCondition=Console.ReadLine().ToLower();
                }
            }while(theaterCondition=="yes");
        }

        public static void TicketCancellation(UserDetails user)
        {
            System.Console.WriteLine("------------------------------------------------------------------------");
            System.Console.WriteLine("|BookingID|UserID|MovieID|TheaterID|SeatCount|TotalAmount|BookingStatus|");
            System.Console.WriteLine("------------------------------------------------------------------------");
            foreach(BookingDetails book in bookList)
            {
                if(user.UserID==book.UserID && book.BookingStatus==Status.Booked)
                {
                    System.Console.WriteLine($"{book.BookingID,-9}|{book.UserID,-6}|{book.MovieID,-7}|{book.TheaterID,-9}|{book.SeatCount,-9}|{book.TotalAmount,-11}|{book.BookingStatus,-13}");
                }
            }
            string condition="yes";
            do
            {
                System.Console.Write("Enter the bookingID, you want to cancel: ");
                string bookingID=Console.ReadLine().ToUpper();
                int temp=0;
                foreach(BookingDetails book in bookList)
                {
                    if(bookingID==book.BookingID)
                    {
                        System.Console.WriteLine("available");
                        foreach(ScreeningDetails screen in screeningList)
                        {
                            if(book.MovieID==screen.MovieID)
                            {
                                screen.NoOfSeatsAvailable+=book.SeatCount;
                                double addAmount=book.TotalAmount-20;
                                user.WalletBalance+=addAmount;
                                book.BookingStatus=Status.Cancelled;
                                System.Console.WriteLine("\n---Booking Cancelled Successfully----\n");
                            }
                        }
                        temp=0;
                        condition="no";
                        break;
                    }
                    else
                    {
                        temp=1;
                    }
                }
                if(temp==1)
                {
                    System.Console.WriteLine("---Invalid BookingID");
                    System.Console.WriteLine("Do you want to continue (yes or no): ");
                    condition=Console.ReadLine().ToLower();
                }
            }while(condition=="yes");
            
        }


        public static void BookingHistory(UserDetails user)
        {
            System.Console.WriteLine("------------------------------------------------------------------------");
            System.Console.WriteLine("|BookingID|UserID|MovieID|TheaterID|SeatCount|TotalAmount|BookingStatus|");
            System.Console.WriteLine("------------------------------------------------------------------------");
            foreach(BookingDetails book in bookList)
            {
                if(user.UserID==book.UserID)
                {
                    System.Console.WriteLine($"{book.BookingID,-9}|{book.UserID,-6}|{book.MovieID,-7}|{book.TheaterID,-9}|{book.SeatCount,-9}|{book.TotalAmount,-11}|{book.BookingStatus,-13}");
                }
            }
        }

        public static void WalletRecharge(UserDetails user)
        {
            System.Console.Write("Enter the amount to recharge: ");
            bool temp2=double.TryParse(Console.ReadLine(),out double amount);
            while(!temp2)
            {
                System.Console.WriteLine("enter the amount to recharge in valid ");
                temp2=double.TryParse(Console.ReadLine(),out amount);
            }
            user.RechargeWallet(user,amount);
            System.Console.WriteLine("Balance After recharge: "+user.WalletBalance);
        }


        public static void DefaultUser()
        {
            //UserDetails
            UserDetails user1=new UserDetails("Ravichandran",30,"8598993437",1000);
            userList.Add(user1);
            UserDetails user2=new UserDetails("Baskaran",30,"6384609921",2000);
            userList.Add(user2);

            //Theater Details
            TheaterDetails theater1=new TheaterDetails("Inox","AnnaNagar");
            theaterList.Add(theater1);
            TheaterDetails theater2=new TheaterDetails("Ega Theater","Chetpet");
            theaterList.Add(theater2);
            TheaterDetails theater3=new TheaterDetails("Kamala","Vadapalani");
            theaterList.Add(theater3);

            //Movie Details
            MovieDetails movie1=new MovieDetails("Bagubali 2","Telugu");
            movieList.Add(movie1);
            MovieDetails movie2=new MovieDetails("Ponniyin Selvan","Tamil");
            movieList.Add(movie2);
            MovieDetails movie3=new MovieDetails("Cobra","Tamil");
            movieList.Add(movie3);
            MovieDetails movie4=new MovieDetails("Vikram","Hindi (Dubbed)");
            movieList.Add(movie4);
            MovieDetails movie5=new MovieDetails("Vikram","Tamil");
            movieList.Add(movie5);
            MovieDetails movie6=new MovieDetails("Beast","English");
            movieList.Add(movie6);

            //ScreeningDetails
            ScreeningDetails screen1=new ScreeningDetails(movie1.MovieID,theater1.TheaterID,5,200);
            screeningList.Add(screen1);
            ScreeningDetails screen2=new ScreeningDetails(movie2.MovieID,theater1.TheaterID,2,300);
            screeningList.Add(screen2);
            ScreeningDetails screen3=new ScreeningDetails(movie6.MovieID,theater1.TheaterID,1,50);
            screeningList.Add(screen3);
            ScreeningDetails screen4=new ScreeningDetails(movie1.MovieID,theater2.TheaterID,11,400);
            screeningList.Add(screen4);
            ScreeningDetails screen5=new ScreeningDetails(movie2.MovieID,theater2.TheaterID,20,300);
            screeningList.Add(screen5);
            ScreeningDetails screen6=new ScreeningDetails(movie4.MovieID,theater2.TheaterID,2,500);
            screeningList.Add(screen6);
            ScreeningDetails screen7=new ScreeningDetails(movie5.MovieID,theater3.TheaterID,11,100);
            screeningList.Add(screen7);
            ScreeningDetails screen8=new ScreeningDetails(movie2.MovieID,theater3.TheaterID,20,200);
            screeningList.Add(screen8);
            ScreeningDetails screen9=new ScreeningDetails(movie4.MovieID,theater3.TheaterID,2,350);
            screeningList.Add(screen9);

            //BookingDetails
            BookingDetails booking1=new BookingDetails(user1.UserID,movie1.MovieID,theater1.TheaterID   ,1  ,200    ,Status.Booked);
            bookList.Add(booking1);
            BookingDetails booking2=new BookingDetails(user1.UserID,movie4.MovieID,theater2.TheaterID,  1   ,400    ,Status.Booked);
            bookList.Add(booking2);
            BookingDetails booking3=new BookingDetails(user2.UserID,movie5.MovieID,theater2.TheaterID,1 ,300    ,Status.Booked);
            bookList.Add(booking3);
        }
    }
}