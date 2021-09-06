using System.IO;
using System;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace Storages
{
    public class ClassStorage
    {
        public static void AllInfo()
        {
            try
            {
               using (StreamReader read = new StreamReader(@"c:CustomersList.txt", true))
               {
                    string text = File.ReadAllText(@"c:CustomersList.txt");
                    Console.WriteLine("Contents of CustomersList.txt is \n {0}", text);
                    //Console.Write(text);  
                    //Console.WriteLine(text);
               }  
            }
            catch (Exception e)
            {
                
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("These is All Customers who are Registered!");
            }

             
        }
    }
}