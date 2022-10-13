using System;
namespace Question11;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the original string: ");
        string originalString=Console.ReadLine();
        string newWord=" ";
        char[] originalChar = originalString.ToCharArray();
        for(int i=0;i<originalString.Length;i++)
        {
            for(int j=i+1;j<originalString.Length;j++)
            {
                if(originalChar[i]==originalChar[j])
                {
                    originalChar[j] = '0';
                }
            }
        }
        for(int i = 0;i<originalChar.Length;i++){
            if(originalChar[i]!='0'){
                newWord += originalChar[i];
            }
        }
        System.Console.WriteLine(newWord);
    }
}
