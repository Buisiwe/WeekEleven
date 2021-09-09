using System;
using Market;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace Customer
{
    public class Login: Customers
    {
    
        public override void LoginUser()
        {
            
            string path = @"c:CustomersList.txt";
            Console.WriteLine("Enter username: ");  //ask the user for the username and store in a variable 
            string userName = Console.ReadLine();
            Console.WriteLine("Enter password: "); //ask the user for the password and store in a variable 
            string passWord = Console.ReadLine();
            string domain = passWord + userName;

            using (StreamReader sr = File.OpenText(path))
            {
            string[] lines = File.ReadAllLines(path);  //read all lines of the file into an array
            bool UserExist = false;  //declares a Boolean variable to track if the user/password exists
            //string[] x;

            for (int x = 0; x < lines.Length - 1; x++)
            {
                if (domain == lines[x])
                {
                    sr.Close();
                    Console.WriteLine("there is a match");
                    UserExist = true;
                    StoreInterface.MarketDisplay();
                }
            }

            if (!UserExist)
            {
                 
                Console.WriteLine("User doesn't exist match match");
                sr.Close();
                //if the Boolean variable is still false the user didn't exist, otherwise register
               // CustomerInterface.RegisterUserInput();
                StoreInterface.MarketDisplay();
               
            }
            
            }
        }
            

        public static void StoFile(string key)
        {

            //Writing elements to the Stores list text file
            try
            {

                using (StreamWriter writer = new StreamWriter(@"c:StoresList.txt", true))
                {

                    writer.WriteLine(key);
                    string text = File.ReadAllText(@"c:StoresList.txt");
                    string result = Regex.Replace(text, @"(^\p{Zs}*\r\n){2,}", "\r\n", RegexOptions.Multiline);
                    File.WriteAllText(@"c:StoresList.txt", result);
                    writer.Close();
                    writer.Dispose();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Store successfully added!");
            }

        }

        }
    }
