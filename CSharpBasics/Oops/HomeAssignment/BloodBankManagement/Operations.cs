using System;
using System.Collections.Generic;
namespace BloodBankManagement
{
    public class Operations
    {
        public static List<UserDetails> donorList=new List<UserDetails>();
        public static List<DonationDetails> donationList=new List<DonationDetails>();
        public static void Mainmenu()
        {
            string choice="yes";
            do
            {
                System.Console.WriteLine("------Main menu-----");
                System.Console.WriteLine("Choose your Option \n1.UserRegistration \n2.UserLogin \n3.FetchDonorDetails \n4.Exit");
                System.Console.Write("Your Option: ");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        {
                            System.Console.WriteLine("   UserRegistration   ");
                            UserRegistration();
                            break;
                        }
                    case 2:
                        {
                            System.Console.WriteLine("   UserLogin   ");
                            UserLogin();
                            break;
                        }     
                    case 3:
                        {
                            System.Console.WriteLine("    FetchDonorDetails   ");
                            FetchDonorDetails();
                            break;
                        }     
                    case 4:
                        {
                            System.Console.WriteLine("   Exit    ");
                            choice="no";
                            break;
                        }      
                }
            }while(choice=="yes");
        }

        public static void UserRegistration()
        {
            System.Console.WriteLine("---- Registration Start----");
            System.Console.WriteLine("Enter the DonorName: ");
            string donorName=Console.ReadLine();
            System.Console.WriteLine("Enter your Age: ");
            int age=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your MobileNumber: ");
            long mobileNumber=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Blood Group(ex: O_Positive): ");
            BloodGroup bloodGroup=Enum.Parse<BloodGroup>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter your NativePlace: ");
            string nativePlace=Console.ReadLine();
            UserDetails user=new UserDetails(donorName,mobileNumber,bloodGroup,age,nativePlace);
            donorList.Add(user);
            System.Console.WriteLine("---Successfully Registered---");
            System.Console.WriteLine("\n Your DonorID: "+user.DonorID+"\n");
        }

        public static void UserLogin()
        {
            int temp=0;
            System.Console.WriteLine("Enter your donorID: ");
            string donorID=Console.ReadLine().ToUpper();
            foreach(UserDetails donor in donorList)
            {
                if(donorID==donor.DonorID)
                {
                    System.Console.WriteLine("----Login Successfully----");
                    Submenu(donor);
                    temp=0;
                    break;
                }
                else
                {
                    temp=1;
                }
            }
            if(temp==1)
            {
                System.Console.WriteLine("---Invalid ID---");
            }
        }

        public static void FetchDonorDetails()
        {
            System.Console.WriteLine("Which Blood group, Do you want(Ex: O_Positive): ");
            BloodGroup bloodWant=Enum.Parse<BloodGroup>(Console.ReadLine(),true);
            foreach(UserDetails donor in donorList)
            {
                if(bloodWant==donor.BloodGroup)
                {
                    System.Console.WriteLine($"|DonorName:{donor.DonorName}|MobileNumber:{donor.MobileNumber}|NativePlace:{donor.NativePlace}");
                }
            }
            
        }

        public static void DefaultUser()
        {
             UserDetails user1=new UserDetails("Ravichandran",848484848,BloodGroup.O_Positive,30,"Theni");
            donorList.Add(user1);
            UserDetails user2=new UserDetails("Baskaran",47474747474,BloodGroup.AB_Positive,30,"Chennai");
            donorList.Add(user2);

            DonationDetails donation1=new DonationDetails(user1.DonorID,new DateTime(2022,06,10),73,120,14);
            donationList.Add(donation1);
            DonationDetails donation2=new DonationDetails(user1.DonorID,new DateTime(2022,10,10),74,120,14);
            donationList.Add(donation2);
            DonationDetails donation3=new DonationDetails(user2.DonorID,new DateTime(2022,07,11),74,120,13.6);
            donationList.Add(donation3);
        }

        public static void Submenu(UserDetails donor)
        {
            string choice="yes";
            do
            {
                System.Console.WriteLine("---Submenu----");
                System.Console.WriteLine("Choose your option \n1.DonateBlood \n2.DonationHistory \n3.NextEligibleDate \n4.Exit");
                System.Console.WriteLine("Your Option: ");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        {
                            System.Console.WriteLine("   DonateBlood   ");
                            DonateBlood(donor);
                            break;
                        }
                    case 2:
                        {
                            System.Console.WriteLine("    DonationHistory    ");
                            DonationHistory(donor);
                            break;
                        }     
                    case 3:
                        {
                            System.Console.WriteLine("   NextEligibleDate    ");
                            NextEligibleDate(donor);
                            break;
                        }      
                    case 4:
                        {
                            System.Console.WriteLine("   Exit   ");
                            choice="no";
                            break;
                        }     
                }
            }while(choice=="yes");
        }

        public static void DonateBlood(UserDetails donor)
        {
            System.Console.WriteLine("Enter your Weight: ");
            double weight=double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the blood Pressure: ");
            double bloodPressure=double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Hemoglobin Count: ");
            double hemoglobinCount=double.Parse(Console.ReadLine());
            if(weight>50 && bloodPressure<130 && hemoglobinCount>13)
            {
                System.Console.WriteLine("Have you ever donate blood(yes or no): ");
                string choice=Console.ReadLine().ToLower();
                if(choice=="yes")
                {
                    System.Console.WriteLine("Enter your Last donationID: ");
                    string lastDonation=Console.ReadLine().ToUpper();
                    int latest=0;
                    int temp=0;
                    foreach(DonationDetails donation in donationList)
                    {
                        if(lastDonation==donation.DonationID)
                        {
                            DateTime lastDate=donation.DonationDate;
                            DateTime nextEligibiltyDate=lastDate.AddDays(60.0);
                            System.Console.WriteLine("NextEligibleDate: "+nextEligibiltyDate.ToString("dd/MM/yyyy"));
                            latest=DateTime.Compare(DateTime.Now,nextEligibiltyDate);
                            System.Console.WriteLine(latest);
                            if(latest<0)
                            {
                                System.Console.WriteLine("Not eligible for donation");
                                temp=0;
                                break;
                            }
                            else
                            {
                               temp=1;
                            }
                        }
                    }
                    if(temp==1)
                    {
                         DonationDetails donation1 = new DonationDetails(donor.DonorID,DateTime.Now,weight,bloodPressure,hemoglobinCount);
                        donationList.Add(donation1);
                        System.Console.WriteLine("---Successfully donated---");
                        System.Console.WriteLine("Your DonationID: "+donation1.DonationID);
                    }
                }
                else
                {
            
                    DonationDetails donation5 = new DonationDetails(donor.DonorID,DateTime.Now,weight,bloodPressure,hemoglobinCount);
                    donationList.Add(donation5);
                    System.Console.WriteLine("---Successfully donated---");
                    System.Console.WriteLine("Your DonationID: "+donation5.DonationID);
                }
            }
            else
            {
                System.Console.WriteLine("Not eligible for donation");
            }
        }

        public static void DonationHistory(UserDetails donor)
        {
            foreach(DonationDetails donation in donationList)
            {
                if(donation.DonorID==donor.DonorID)
                {
                    System.Console.WriteLine($"|DonationID:{donation.DonationID}  |DonorID:{donation.DonorID}   |DonationDate:{donation.DonationDate.ToString("dd/MM/yyyy")}  |Weight:{donation.Weight}  |BloodPressure:{donation.BloodPressure}  |HemoglobinCount:{donation.HemoglobinCount}|");
                }
            }
        }

        public static void NextEligibleDate(UserDetails donor)
        {
            DonationHistory(donor);
            System.Console.WriteLine("Enter your Last donationID: ");
            string lastDonation=Console.ReadLine();
            foreach(DonationDetails donation in donationList)
            {
                if(lastDonation==donation.DonationID)
                {
                     DateTime lastDate=donation.DonationDate;
                    DateTime nextEligibiltyDate=lastDate.AddDays(60.0);
                    System.Console.WriteLine("NextEligibleDate: "+nextEligibiltyDate.ToString("dd/MM/yyyy"));

                }
            }
        }
    }
}