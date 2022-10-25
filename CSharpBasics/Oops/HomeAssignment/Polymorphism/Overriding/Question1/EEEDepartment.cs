namespace Overriding
{
    public class EEEDepartment:Library
    {
        public override string AuthorName { get; set; }
        public override string BookName { get; set; }
        public override string PublisherName { get; set; }
        public override int Year { get; set; }


          public override void BookInfo(string authorName,string bookName,string publisherName,int year)
        {
            AuthorName=authorName;
            BookName=bookName;
            PublisherName=publisherName;
            Year=year;
        }

        public override void Display()
        {
            System.Console.WriteLine($" \n AuthorName:{AuthorName} \n BookName:{BookName} \n PublisherName:{PublisherName} \n Year:{Year}" );
        }
    }
}