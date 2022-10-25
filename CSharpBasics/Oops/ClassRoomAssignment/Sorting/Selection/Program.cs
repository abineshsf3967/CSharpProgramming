using System;
namespace Selection;
class Program
{
    public static void Main(string[] args)
    {
        int value,value2,minValue,minIndex;
        int[] numbers={5,3,8,6,9,1};
        for(value=0;value<numbers.Length;value++)
        {
            minValue=numbers[value];
            minIndex=value;
            for(value2=value;value2<numbers.Length;value2++)
            {
                if(numbers[value2]<minValue)
                {
                    minValue=numbers[value2];
                    minIndex=value2;
                }
            }    
            if(minValue<numbers[value])
            {
                int temp=numbers[value];
                numbers[value]=minValue;
                numbers[minIndex]=temp;
            }
            
        }
        foreach(int check in numbers)
        {
            System.Console.Write(check+"\t");
        }

    }
}