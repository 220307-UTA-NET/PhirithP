namespace CryptoStore
{

    class EternalFlowLocation : EternalFlow
    {
    //Fields

    //Constructor
    public EternalFlowLocation ( string customerName, string eternalFlowLocation, double eternalFlowInventory, string itemsOrdered, double priceOfItems )
    {
        this.customerName = customerName;
        this.eternalFlowLocation = eternalFlowLocation;
        this.eternalFlowInventory = eternalFlowInventory;
        this.itemsOrdered = itemsOrdered;
        this.priceOfItems = priceOfItems;

    }
        //Methods
        public override void DecreaseInventory (double decreaseInventory)
        {
            throw new NotImplementedException();
        }
       
    }
}