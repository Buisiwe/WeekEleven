using System;
using System.Collections.Generic;
using Market;
using Storages;
namespace Customer
{
    public class StoreInterface
    {
        private static string StoreName;
        private static string typeName;
        private static string items;
        private static string password;
        public static void Display()
        {
            bool customerContinue = true;
            while (customerContinue)
            {
                System.Console.WriteLine("---------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Welcome to Buisiwe's Type of Market App");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter: ");
                Console.WriteLine("1 to register user");
                Console.WriteLine("2 to login on Type of Market App");
                Console.WriteLine("3 to See All Registered Customers");
                Console.WriteLine("4 to See All Customers who has Stores");
                Console.WriteLine("0 to exit");
                Console.Write("\r\nSelect an option: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        CustomerInterface.RegisterUserInput();
                        break;
                    case "2":
                        CustomerInterface.LoginDetail();
                        break;
                    case "3":
                        ClassStorage.AllCustomers();
                        break;
                    case "4":
                        ClassStorage.AllInfo();
                        break;
                    case "0":
                        try
                        {
                            customerContinue = false;
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("Thank you for using Buisiwe's Type of Market App!");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        catch (ArithmeticException ex) //Catches all errors relating to arithmetic operations
                        {

                            Console.WriteLine(ex.Message);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    default:
                        Console.Clear();
                        break;
                }

            }
        }

        public static void MarketDisplay()
        {
            bool loginProceed = true;
            while (loginProceed)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter Type of Market: ");
                Console.WriteLine("1 Buy store.");
                Console.WriteLine("2 Show stores.");
                Console.WriteLine("3 return on stores.");
                Console.WriteLine("4 return main menu.");
                Console.Write("\r\nSelect an option: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        StoreInterface.StoreInfo();
                    break;
                    case "2":
                        ClassStorage.AllStores();
                    break;
                    case "3":
                        MarketDisplay();
                    break;
                    case "4":
                        StoreInterface.Display();
                    break;
                    case "5":
                        loginProceed = false;
                    break;
                    
                }
            }
         
       }
       public static void StoreInfo()
       {
           List<string> userInfo =new List<string>();
           Console.Write("enter name of your store: ");
           StoreName = Console.ReadLine();
           Console.Write("key in type of store either Kiosk or Supermarket: ");
           typeName = Console.ReadLine();
           Console.Write("enter an item in your store: ");
           items = Console.ReadLine();
           userInfo.Add(StoreName);
           userInfo.Add(typeName);
           userInfo.Add(items);
           string stores = string.Join("       |      ", userInfo);
           Login.StoFile(stores);

           
       }

        
    }
}