using System;
namespace Binary;
class Program
{
    public static void Main(string[] args)
    {
        int[] numbers={1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
        int start=numbers[0];
        int last=numbers.Length-1;
        int end=numbers[last];
        System.Console.WriteLine("length of array"+end);
        int center=(start+end)/2;
        
        System.Console.WriteLine(" Enter the number to find: ");
        int findNumber=int.Parse(Console.ReadLine());

        for(int value=1;value<numbers.Length-1;value++)
        {
            int mid=numbers[center];
            if(findNumber==mid)
            {
                System.Console.WriteLine($"The number {findNumber} in index  {center}");
                break;
                
            }
            else if(findNumber<mid)
            {
                center--;
            }
            else
            {
                center++;
            }
        }
    }
}
