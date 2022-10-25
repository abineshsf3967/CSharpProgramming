namespace LibraryInfo
{
    public class BookInfo:DepartmentDetails
    {
        private static int s_bookID=100;
        public string BookID { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public double Price { get; set; }

        public BookInfo(string departmentName,string degree,string bookName,string authorName,double price):base(departmentName,degree)
        {
            s_bookID++;
            BookID="BI"+s_bookID;
            BookName=bookName;
            AuthorName=authorName;
            Price=price;
        }


        public void DispalyBook()
        {
            System.Console.WriteLine("BookID: "+BookID);
            System.Console.WriteLine("BookName: "+BookName);
            System.Console.WriteLine("AuthorName: "+AuthorName);
            ShowDetails();
            System.Console.WriteLine("Price: "+Price);
        }
    }
}