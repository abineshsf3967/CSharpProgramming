using System;
namespace EnumTypes
{
    public enum Gender{Default,male,female,transgender}
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Select gender options MALE,FALSE,TRANSGENDER");
            Gender gender1=Enum.Parse<Gender>(Console.ReadLine(),true);// true for case exception
            System.Console.WriteLine(gender1);

             System.Console.WriteLine("Select gender options MALE,FALSE,TRANSGENDER");
             Gender gender2=Gender.Default;
             bool temp=Enum.TryParse<Gender>(Console.ReadLine().ToLower(),out gender2);
             while(!temp || !((int)gender2<4)&& (int) gender2>0)
             {
                System.Console.WriteLine("Invalid Gender \n  enter again");
                temp=Enum.TryParse<Gender>(Console.ReadLine(),true,out gender2);
             }
             System.Console.WriteLine(gender2);
            
        }
    }
}