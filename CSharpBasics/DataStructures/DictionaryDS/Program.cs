using System;
namespace DictionaryDS;
class Program
{
    public static void Main(string[] args)
    {
        Dictionary<long,string> number=new Dictionary<long, string>();
        number.Add(6382600921,"abinesh");
        number.Add(638260,"abi");
        number.Add(6382600921,"abinesh");
        System.Console.WriteLine(number.ContainsKey(6382600921));
        System.Console.WriteLine(number.ContainsValue("abinesh"));
        foreach(KeyValuePair<long,string> check in number)
        {
            System.Console.WriteLine(check.Key+" "+check.Value);

        }
        System.Console.WriteLine(number[6382600921]);
        System.Console.WriteLine();
        number[6382600921]="Ravi";
        System.Console.WriteLine(number[6382600921]);
    }
}
