namespace AbstractClass
{
    public class Syncfuison:Employee
    {
        public override string Name { get{return name;} set{name=value;} }
        public override void Salary(int date)
        {
            Display();
            Amount=(double)(date*500);
            System.Console.WriteLine(Amount);
        }
    }
}