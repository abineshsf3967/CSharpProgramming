using System;
namespace StackDS;
class Program
{
    public static void Main(string[] args)
    {
        Stack<string> myStack=new Stack<string>(3);
        Stack<int> myStack1=new Stack<int>();
        myStack.Push("One");
        myStack.Push("TWO");
        myStack.Push("Three");
        myStack.Push("Four");
        System.Console.WriteLine(myStack.Peek());
        System.Console.WriteLine(myStack.Pop());
        System.Console.WriteLine(myStack.Contains("Three"));

    }
}