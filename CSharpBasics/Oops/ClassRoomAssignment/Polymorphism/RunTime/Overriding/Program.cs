using System;
namespace Overriding;
class Program
{
    public static void Main(string[] args)
    {
        Animal animal=new Animal();
        animal.Eat();
        System.Console.WriteLine();
        Dog dog=new Dog();
        dog.Eat();
        System.Console.WriteLine();
        Pomerian pomerian=new Pomerian();
        pomerian.Eat();
    }
}
