using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace Customer
{
    public class Register: Customers
    {
        public static void CustFile(string key)
        {

            //Writing elements to the Customer list text file
            try
            {

                using (StreamWriter writer = new StreamWriter(@"c:CustomersList.txt", true))
                {

                    writer.WriteLine(key);
                    string text = File.ReadAllText(@"c:CustomersList.txt");
                    string result = Regex.Replace(text, @"(^\p{Zs}*\r\n){2,}", "\r\n", RegexOptions.Multiline);
                    File.WriteAllText(@"c:CustomersList.txt", result);
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
                Console.WriteLine("Customer successfully registered!");
            }

        }
    }
}