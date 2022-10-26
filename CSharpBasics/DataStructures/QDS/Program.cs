using System;
namespace QDS;
class Program
{
    public static void Main(string[] args)
    {
        Queue<string> myQueue=new Queue<string>();
        myQueue.Enqueue("One");
        myQueue.Enqueue("Two");
        myQueue.Enqueue("Three");
        myQueue.Enqueue("Four");
        System.Console.WriteLine(myQueue.Peek());
        System.Console.WriteLine(myQueue.Dequeue());
        System.Console.WriteLine(myQueue.Contains("One"));
    }
}