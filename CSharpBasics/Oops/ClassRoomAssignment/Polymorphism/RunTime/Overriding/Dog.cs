namespace Overriding
{
    public class Dog:Animal
    {
        public override void Eat()
        {
            System.Console.WriteLine("I eat dog food");
        }
    }
}