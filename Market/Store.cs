namespace Market
{
    public interface Store
    {
        public string nameOfMarket { get; set; }
        public string productType { get; set; }
        public int noOfProduct { get; set; }
        private static int storeNumber = 1;//Use of encapsulation field that will keep on generating while registering new user

        public static int GenerateStoreNo()
        {
            return storeNumber++;//increment id by 1 when registering user
        }
        public static void addProduct()
        {

        }
        public static void RemoveProduct()
        {

        } 
    }
}