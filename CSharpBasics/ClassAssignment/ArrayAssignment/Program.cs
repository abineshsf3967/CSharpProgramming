using System;
namespace ArrayAssignment;
class Program
{
    public static void Main(string[] args)
    {
        string[] names={"mani","ganesh","venkat","suresh","venkat"};
        for(int index=0;index<names.Length;index++)
        {
            System.Console.WriteLine(names[index]);
        }
        System.Console.WriteLine("Enter the new name: ");
        string newName= Console.ReadLine();
        int temp=0;
        for(int i=0;i<names.Length;i++)
        {
           if(newName==names[i])
           {
             System.Console.WriteLine("name is present");
               temp=1;
               break;
           }
        }
        if(temp!=1)
        {
            System.Console.WriteLine("name is not present");
        }
        int count=0;
        System.Console.WriteLine("By foreach loop: ");
        foreach(string check in names)
        {
             if(check==newName)
             {
                System.Console.WriteLine("name is present");
                count=1;
                break;
             }
        }
        if(count!=1)
        {
            System.Console.WriteLine("name is not present");
        }
    

        
    }
}