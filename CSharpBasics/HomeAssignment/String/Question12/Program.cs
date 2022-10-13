using System;
namespace Question12;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("enter the string: ");
        string word=Console.ReadLine();
        string get="";
        string[] nextString=word.Split(new char[]{' '});
        foreach(string check in nextString)
        {
           get=get+check;
        }
        System.Console.WriteLine();
        char m=get[0];
        for(int i=0;i<get.Length;i++)
        {
            if(get[i]>m)
            {
                m=get[i];
            }
        }
        System.Console.WriteLine("maximum: "+m);
        System.Console.WriteLine();
        char n=get[0];
        for(int i=0;i<get.Length;i++)
        {
            if(get[i]<n)
            {
                n=get[i];
            }
        }
        System.Console.WriteLine("minimum: "+n);
            
        
    }
}
