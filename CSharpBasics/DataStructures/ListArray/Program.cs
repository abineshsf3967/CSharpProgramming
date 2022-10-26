using System;
namespace ListArray;
class Program
{
    public static void Main(string[] args)
    {
        ArrayList numberList=new ArrayList();
        numberList.Add(10);
        numberList.Add("Abinesh");
        numberList.Add('a');
        numberList.Add(112.345);
        numberList.Add(11);
        ArrayList secondList=new ArrayList();
        secondList.Add("Ravi");
        secondList.Add(12);
        numberList.AddRange(secondList);
        numberList.Insert(1,"baskaran");
        numberList.RemoveAT(1);
        numberList.Remove('a');
        System.Console.WriteLine(numberList.Contains("Ravi"));
        numberList.ToArray();
        System.Console.WriteLine();
        foreach(var check in numberList)
        {
            System.Console.WriteLine(check);
        }
        System.Console.WriteLine();
        for(int i=0;i<numberList.Count;i++)
        {
            System.Console.WriteLine(numberList[i]);
        }
    }
}
