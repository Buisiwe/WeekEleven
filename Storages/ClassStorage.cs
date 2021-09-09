using System.IO;
using System;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace Storages
{
    public class ClassStorage
    {
        public static void AllCustomers()
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

        public static void AllStores()
        {
            try
            {
               using (StreamReader read = new StreamReader(@"c:StoresList.txt", true))
               {
                    string text = File.ReadAllText(@"c:StoresList.txt");
                    Console.WriteLine("Contents of StoresList.txt is \n {0}", text);
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
                Console.WriteLine("These is are all Stores !");
            } 
        }

        public static void AllInfo()
        {
            try{
                string customerfile = @"c:CustomersList.txt";
                string storefile = @"c:StoresList.txt";
                string combo = @"c:DetailsList.txt";

                string[] customernames = File.ReadAllLines(customerfile);
                string[] storenames = File.ReadAllLines(storefile);

                using (TextWriter textWriter = new StreamWriter(combo))
                for (int i = 0; i < storenames.Length; i++)
                for (int j = 0; j < customernames.Length; j++)
                textWriter.WriteLine("{0}" + "\t{1}", storenames[i], customernames[j]);

            }
             catch (Exception e)
            {
                
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("These is are list of Customers and Stores together!");
            } 
            
        }

    }
}