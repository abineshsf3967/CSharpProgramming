namespace OnlineLibrary
{
    public class BookInfo:RackInfo
    {
        private static int s_bookID=100;

        public string BookID { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public double Price { get; set; }


        public BookInfo(string departmentName,string degree,int rackNumber,int columnNumber,string bookName,string authorname,double price):base(departmentName,degree,rackNumber,columnNumber)
        {
            s_bookID++;
            BookID="BI"+s_bookID;
            BookName=bookName;
            AuthorName=authorname;
            Price=price;
        }


        public void ShowBookInfo()
        {
            System.Console.WriteLine("BookID: "+BookID);
            System.Console.WriteLine("BookName: "+BookName);
              System.Console.WriteLine("Author Name: "+AuthorName);
            System.Console.WriteLine("Department: "+DepartmentName);
            System.Console.WriteLine("Degree: "+Degree);
            System.Console.WriteLine("ColumnNumber: "+ColumnNumber);
            System.Console.WriteLine("RackNumber: "+RackNumber);
            System.Console.WriteLine("Price: "+Price);

        }
    }
}