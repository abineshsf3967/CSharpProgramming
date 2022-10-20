using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Please note - THIS IS A BAD APPLICATION - DO NOT REPLICATE WHAT IT DOES
// This application was designed to simulate a poorly-built application that
// you need to support. Do not follow any of these practices. This is for 
// demonstration purposes only. You have been warned.
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        { 
            string workPlace;
            int i;
            double workedHours, totalHours;
            List<TimeSheetEntry> entries = new List<TimeSheetEntry>();
            Console.Write("Enter where did you work: ");
            workPlace = Console.ReadLine();
            Console.Write("How many hours did you work: ");
            workedHours = double.Parse(Console.ReadLine());
            TimeSheetEntry entry = new TimeSheetEntry();
            entry.HoursWorked = workedHours;
            entry.WorkDone = workPlace;
            entries.Add(entry);
            Console.Write("Do you want to enter another company details (yes or no):");
            string choice = Console.ReadLine().ToLower();
            while(choice=="yes")
            {
                Console.Write("Enter what you did: ");
                workPlace = Console.ReadLine();
                Console.Write("How long did you do it for: ");
                workedHours = double.Parse(Console.ReadLine());
                TimeSheetEntry entry1 = new TimeSheetEntry();
                entry1.HoursWorked = workedHours;
                entry1.WorkDone = workPlace;
                entries.Add(entry1);
                Console.Write("Do you want to enter another company details:");
                choice =(Console.ReadLine().ToLower());
            }
            totalHours = 0;
            for (i = 0; i < entries.Count; i++)
            {
                if (entries[i].WorkDone.ToLower().Contains("acme"))
                {
                    totalHours += entries[i].HoursWorked;
                    
                }
                
            }
            Console.WriteLine("Simulating Sending email to Acme");
            Console.WriteLine("Your bill is $" + totalHours * 150 + " for the hours worked.");
            totalHours=0;
            for (i = 0; i < entries.Count; i++)
            {
                if (entries[i].WorkDone.ToLower().Contains("ABC"))
                {
                    totalHours += entries[i].HoursWorked;
                 
                }
                
            }
            Console.WriteLine("Simulating Sending email to ABC");
            Console.WriteLine("Your bill is $" + totalHours * 125 + " for the hours worked.");
            totalHours=0;
            for (i = 0; i < entries.Count; i++)
            {
                totalHours += entries[i].HoursWorked;
            }
            if (totalHours > 40)
            {
                double hours=totalHours-40;
                double amount1=hours*15;
                double amount2=40*10;
                double totalamount=amount1+amount2;
                Console.WriteLine("You will get paid $" + totalamount + " for your work.");
            }
            else
            {
                Console.WriteLine("You will get paid $" + totalHours * 10 + " for your time.");
            }
            Console.WriteLine();
            Console.Write("Press any key to exit application...");
            Console.ReadKey();
        }
    }

    public class TimeSheetEntry
    {
        public string WorkDone;
        public double HoursWorked;
    }
}
