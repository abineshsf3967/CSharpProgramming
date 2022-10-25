using System;
namespace Bubble;
class Program
{
    public static void Main(string[] args)
    {
        int value,value2,temp=0;
        int[] numbers={78,10,24,56,5,1};
        for(value=0;value<numbers.Length-1;value++)
        {
            for(value2=0;value2<numbers.Length-1-value;value2++)
            {
                if(numbers[value2]>numbers[value2+1])
                {
                    temp=numbers[value2];
                    numbers[value2]=numbers[value2+1];
                    numbers[value2+1]=temp;
                }
            }
        }
        foreach(int check in numbers)
        {
            System.Console.Write(check+"\t");
        }
    }
}