namespace CryptoStore
{
    class EternalFlowCustomers : EternalFlow 
    {
        //fields


        //constructors
         public EternalFlowCustomers ( string customerName, string eternalFlowLocation )
        {
            this.customerName = customerName;
            this.eternalFlowLocation = eternalFlowLocation;
        }


        //methods
        public override void DecreaseInventory (double decreaseInventory)
        {
            throw new NotImplementedException();
        }
    }
}