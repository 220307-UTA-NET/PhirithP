namespace CryptoStore
{
    class EternalFlowOrders : EternalFlow 
    {
        //fields


        //constructors
        public EternalFlowOrders ( string customerName, string eternalFlowLocation, string itemsOrdered, double priceOfItems )
        {
            this.customerName = customerName;
            this.eternalFlowLocation = eternalFlowLocation;
            this.itemsOrdered = itemsOrdered;
            this.priceOfItems = priceOfItems;

        }

        //methods
        public override void DecreaseInventory (double decreaseInventory)
        {
            throw new NotImplementedException();
        }
    }
}