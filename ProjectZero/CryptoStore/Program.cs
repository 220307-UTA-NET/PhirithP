using System;

namespace CryptoStore
{
    class program 
    {
        static void Main()
        {
            //The program starts here...
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------------------------------------");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("***** Welcome to EternalFlow Online Crypto Store! ******");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------------------------------------");
         
            //EternalFlowLocation class code execution
            EternalFlowLocation newEternalFlowLocation = new EternalFlowLocation ("Ryo Goken", "Los Angeles", 5000, "Bitcoin Shirt", 56.33);

            Console.WriteLine("EternalFlow Customer = " + newEternalFlowLocation.customerName);
            Console.WriteLine("Location: " + newEternalFlowLocation.GetEternalFlowHQ());
            Console.WriteLine("Number of Items in Inventory:  " + newEternalFlowLocation.GetEternalFlowInventory());
            Console.WriteLine("Item/s Ordered:  " + newEternalFlowLocation.GetItemsOrdered());
            Console.WriteLine("Price of Item/s:  " + newEternalFlowLocation.GetPricesOfItems());

            //EternalFlowInventory class code execution
            EternalFlowInventory newEternalFlowInventory = new EternalFlowInventory ("Los Angeles", 5000, 56.33);

            newEternalFlowInventory.DecreaseInventory(4500);
            Console.WriteLine("Number of Items in Inventory:  " + newEternalFlowInventory.GetEternalFlowInventory());
            // newEternalFlowInventory.DecreaseInventory(5623);
            // Console.WriteLine("Number of Items in Inventory:  " + newEternalFlowInventory.GetEternalFlowInventory());
            // newEternalFlowInventory.DecreaseInventory(-5623);
            // Console.WriteLine("Number of Items in Inventory:  " + newEternalFlowInventory.GetEternalFlowInventory());

        }
    }
}
