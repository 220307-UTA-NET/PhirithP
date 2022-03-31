namespace CryptoStore
{
    class EternalFlowInventory : EternalFlow
    {
        //Fields

        //Constructors
        public EternalFlowInventory (string eternalFlowLocation, double eternalFlowInventory, double priceOfItems)
        {
            this.eternalFlowLocation = eternalFlowLocation;
            this.eternalFlowInventory = eternalFlowInventory;
            this.priceOfItems = priceOfItems;

        }
        
        //Methods
        public override void DecreaseInventory(double decreaseInventory)
        {
            if ( decreaseInventory < 0 )
            {
                Console.WriteLine("Item is sold out.");
                Console.WriteLine("Transcion is cancelled.");
            }
            else if( (this.eternalFlowInventory - decreaseInventory) < 0)
            {
                Console.WriteLine("Sorry. We're out of that item. Transaction is cancelled.");
                Console.WriteLine("Please choose another item. Thank you!");
            }
            else
            {
                this.eternalFlowInventory -= decreaseInventory;
            }
        }

    }
}