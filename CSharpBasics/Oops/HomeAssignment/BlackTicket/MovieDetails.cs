namespace BlackTicket
{
    public class MovieDetails
    {
        private static int s_movieID=1000;
        public string MovieID { get; set; }
        public string MovieName { get; set; }
        public string Language { get; set; }

        public MovieDetails(string movieName,string language)
        {
            s_movieID++;
            MovieID="MID"+s_movieID;
            MovieName=movieName;
            Language=language;
        }
        public MovieDetails(string data)
        {
            string[] values=data.Split(',');
            s_movieID=int.Parse(values[0].Remove(0,3));
            MovieID=values[0];
            MovieName=values[1];
            Language=values[2];
        }
    }
}