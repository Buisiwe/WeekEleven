using System;
using System.IO;
using Market;
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
                 
                Console.WriteLine("User doesn't exist");
                sr.Close();
                //if the Boolean variable is still false the user didn't exist, otherwise register
                CustomerInterface.RegisterUserInput();
               
            }
            
            }
            

        }
    }
}