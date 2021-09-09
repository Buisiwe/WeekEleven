using System;
namespace Market
{
    public class Supermarket: Store
    {
        public string _nameOfMarket {get; set;}
        public string _marketType {get; set;}
        public string _itemsName {get; set;}
        protected static int storeIdNumber = 101;
        public static int GenerateStoreNo()
        {
            return storeIdNumber++;//increment id by 1 when registering user
        }
         public void AllDetail(string nameOfMarket, string marketType, string itemsName)
         {
             
            _nameOfMarket = nameOfMarket;
            _marketType = marketType;
            _itemsName = itemsName;
            GenerateStoreNo();
         } 
         //method to add stores to the customer
        public void AddStore (string item)
        {

        }
         //method to delete stores from the customer
        public void deleteStore()
        {

        }
         //method to calculate numbers of stores
         public void NumOfStores(int  num)
         {   //number of supermarket stores should not exceed 700
             Console.WriteLine("The number of product should be less or equal to 700");
         } 
         
          
    }
}