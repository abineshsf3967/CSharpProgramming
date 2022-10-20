namespace RunTimePolymorphism
{
    public class Total:Sport
    {
        public int AcademicMark=50;
        public override void Display()
        {
            TotalMarks=AcademicMark+SportMark;
            System.Console.WriteLine("Name:"+Name+" "+"Mark: "+TotalMarks);
        }
    }
}