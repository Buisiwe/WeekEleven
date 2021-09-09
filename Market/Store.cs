namespace Market
{
    public interface Store
    {
        public string _nameOfMarket {get; set;}
        public string _marketType {get; set;}
        public string _itemsName {get; set;}
        protected static int storeIdNumber = 101;//Use of encapsulation field that will keep on generating while registering new user

        static int GenerateStoreNo()
        {
            return storeIdNumber++;//increment id by 1 when registering user
        }
        void AllDetail(string nameOfMarket, string marketType, string itemsName)
        {
            _nameOfMarket = nameOfMarket;
            _marketType = marketType;
            _itemsName = itemsName;
            GenerateStoreNo(); 
        
        }
        //method to add stores to the customer
        void AddStore (string item);
         //method to delete stores from the customer
        void deleteStore();
        //method to calculate numbers of stores a customer have
        void NumOfStores(int  num);
    }
}