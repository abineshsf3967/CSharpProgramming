namespace Overriding
{
    public class Library
    {
        private static int s_serialNumber=1000;
        public  string SerialNumber { get; set; }
        public virtual string AuthorName { get; set; }
        public virtual string BookName { get; set; }
        public virtual string PublisherName { get; set; }
        public virtual int Year { get; set; }

        public virtual void BookInfo(string authorName,string bookName,string publisherName,int year)
        {
            s_serialNumber++;
            SerialNumber="LIB"+s_serialNumber;
            AuthorName=authorName;
            BookName=bookName;
            PublisherName=publisherName;
            Year=year;
        }

        public virtual void Display()
        {
            System.Console.WriteLine($"serialanumber:{SerialNumber} \n AuthorName:{AuthorName} \n BookName:{BookName} \n PublisherName:{PublisherName} \n Year:{Year}" );
        }
    }
}