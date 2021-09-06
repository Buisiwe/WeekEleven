using System;
using System.Collections.Generic;
using Market;
using Storages;
namespace Customer
{
    public class StoreInterface
    {
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
                Console.WriteLine("3 to See All Customers");
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
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Enter Type of Market: ");
            Console.WriteLine("1 Kiosk");
            Console.WriteLine("2 Supermarket");
            Console.Write("\r\nSelect an option: ");
            switch (Console.ReadLine())
            {
                case "1":
                    Kiosk.GenerateStoreNo();
                    break;
                case "2":
                    Supermarket.GenerateStoreNo();
                    break;
            }
        }
    }
}