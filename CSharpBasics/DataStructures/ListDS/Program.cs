using System;
namespace ListDS;
class Program
{
    public static void Main(string[] args)
    {
        List<int> numberList=new List<int>();
        numberList.Add(10);
        numberList.Add(20);
        numberList.Add(30);
        numberList.Add(40);
        numberList.Add(50);
        System.Console.WriteLine(numberList.Capacity);
        List<int> secondList=new List<int>();
        secondList.Add(60);
        secondList.Add(70);
        numberList.AddRange(secondList);
        numberList.Insert(1,98);
        numberList.RemoveAT(2);
        numberList.IndexOf(50);
        numberList.Remove(40);
        numberList.Contains(50);
        numberList.ToArray();
        System.Console.WriteLine();
        foreach(int value in numberList)
        {
            System.Console.WriteLine(value);
        }
        System.Console.WriteLine();
        for(int i=0;i<numberList.Count;i++)
        {
            System.Console.WriteLine(numberList[i]);
        }
    }
}
