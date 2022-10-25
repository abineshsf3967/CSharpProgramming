using System;
namespace Insertion;
class Program
{
    public static void Main(string[] args)
    {
        int[] numbers={5,8,1,3,9,6};
        int flag=numbers[0];
        for(int value=0;value<numbers.Length;value++)
        {
            for(int value2=value+1;value2<numbers.Length;value2++)
            {
                if(numbers[value]>numbers[value2])
                {
                    int temp=numbers[value];
                    numbers[value]=numbers[value2];
                    numbers[value2]=temp;
                }
            }
        }
       foreach (int check in numbers)
       {
          System.Console.Write(check+"\t");
       }
    }
}

