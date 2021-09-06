using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace Customer
{
    public class CustomerInterface
    {
        private static string name;
        private static string surname;
        private static string email;
        private static string password;
        public static void RegisterUserInput()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                List<string> userdetail = new List<string>();
                Console.WriteLine("Please enter your name:  ");
                name = Console.ReadLine();
                ValidateNames(name);
                Console.WriteLine("Please enter your surname:   ");
                surname = Console.ReadLine();
                ValidateNames(surname);
                Console.WriteLine("Please enter your email address:   ");
                email = Console.ReadLine();
                IsValidEmail(email);
                Console.WriteLine("Please enter your password:   ");
                password = Console.ReadLine();
                userdetail.Add(name);
                userdetail.Add(surname);
                userdetail.Add(email);
                userdetail.Add(password);
                string Something = string.Join("       |      ", userdetail);
                Register.CustFile(Something);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Clear();
            }
        }
        public static void LoginDetail()
        {
            Login log = new Login();
            log.LoginUser();

        }
        //if (username == "admin")
        //throw new InvalidOperationException();

        // _userRepository.Insert(...);

        //_emailService.Send(...);

        public static bool IsValidEmail(string newEmail)
        {
            try
            {
                if (!Regex.IsMatch(email, @"^[^@\s\.]+@[^@\s]+\.[^@\s]+$"))
                {
                    Console.WriteLine("invalid email format. Enter something like: name@domain.com");
                    Console.Clear();
                    Console.WriteLine("Please re-enter valid email: ");
                    newEmail = Console.ReadLine();
                    email = newEmail;
                    return false;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Clear();
            }

            return true;
        }

        public static string ValidateNames(string name)
        {
            var fChar = (int)name[0];
            if (!double.IsNaN(fChar))
            {
                if (fChar >= 65 || fChar <= 90)
                {
                    return name;
                }
                return name.ToUpper()[0] + name.Substring(1);
            }
            while (int.TryParse(name[0].ToString(), out int _))
            {
                name = name.Substring(1);
            }
            return ValidateNames(name);
        }

    }
}