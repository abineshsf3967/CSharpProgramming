using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
        int input=1;
        System.Console.WriteLine("even numbers: ");
        while(input<=100)
        {
            if(input%2==0)
            {
                System.Console.WriteLine(input);
            }
            input++;
        }
        System.Console.WriteLine("odd numbers");
        int value=1;
        while(value<=100)
        {
            if(value%2!=0)
            {
                System.Console.WriteLine(value);
            }
            value++;
        }
        int j=2;
        int number=2;
        System.Console.WriteLine("prime number");
        for(int i=number;i<=100;i++)
        {
        while(j<=i && i<=100)
        {
            if(i%j==0)
            {
                break;
            }
            j++;
            
        }
        if(i==j)
        {
            System.Console.WriteLine(i);
        }
        j=2;
    }
}
}