namespace CryptoStore
{
    abstract class EternalFlow //abstract is a template, does not a constructor, all methods are designed to be overridden
    {
        //Fields
        public string? customerName;
        protected string? eternalFlowLocation;
        protected double eternalFlowInventory;
        protected string? itemsOrdered;
        protected double priceOfItems;

        //Constructor
        
        //Methods 
        public string? GetEternalFlowHQ()
        {
            return this.eternalFlowLocation;
        }

        public double GetEternalFlowInventory()
        {
            return this.eternalFlowInventory;
        }
        
        public string? GetItemsOrdered()
        {
            return this.itemsOrdered;

        }

        public double GetPricesOfItems()
        {
            return this.priceOfItems;
        }

        public abstract void DecreaseInventory (double decreaseInventory);
        
    }
}