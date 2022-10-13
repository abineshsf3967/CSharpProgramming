using System;
namespace Month;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Choose the given option:  \n 1.January \n 2.February \n3.March \n4.April \n5.May \n6.June \n7.July \n8.August \n9.September \n10.October \n11.November \n12.December");
        System.Console.WriteLine("Enter your option: ");
        int month = Convert.ToInt32(Console.ReadLine());
        int temp=0;
        if(month%2==0 && month>0)
        {
            if(month!= 8 && month<8 && month>0)
            {
                  if(month==2)
                  {
                        temp=2;
                  }
                  else{
                        if(month<8 && month>0)
                        temp=1;
                  }
                  
            }
            else 
            {
                  if(month<=12 && month>0)
                  {
                  temp=3;
                  }
            }
        }
        else
        { 
             if(month<=7 && month>0)
             {
                  temp=3;
             }
             else
             { 
                  if(month<12)
                  {
                  temp=1;
                  }
             }
        }
        switch(temp)
        {
            case 1: 
                     {
                        System.Console.WriteLine("Month have 30 days");
                     }    
                     break;   
            case 2:
                     {
                        System.Console.WriteLine("Month have 28 0r 29 days ");
                     }                  
                     break;
            case 3:
                     {
                        System.Console.WriteLine("Month have 31 days");
                     }    
                     break;
            default :
                      {
                        System.Console.WriteLine("Invalid Option");
                      }         
                      break;
        }
    }
}
