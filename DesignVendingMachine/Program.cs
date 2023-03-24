using DesignVendingMachine.VendingStates;
using System;
using System.Collections.Generic;

namespace DesignVendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new VendingMachine(10);
            Console.WriteLine("filling up the inventory");
            fillUpInventory(vendingMachine);
            displayInventory(vendingMachine);

            Console.WriteLine("clicking on InsertCoinButton");

            State vendingState = vendingMachine.GetVendingMachineState();
            vendingState.ClickOnInsertCoinButton(vendingMachine);

            vendingState = vendingMachine.GetVendingMachineState();
            vendingState.InsertCoin(vendingMachine, Coin.NICKEL);
            // vendingState.InsertCoin(vendingMachine, Coin.QUARTER);
            // vendingState.insertCoin(vendingMachine, Coin.NICKEL);

            Console.WriteLine("clicking on ProductSelectionButton");


            vendingState.ClickOnStartProductSelectionButton(vendingMachine);

            vendingState = vendingMachine.GetVendingMachineState();
            vendingState.ChooseProduct(vendingMachine, 102);

            displayInventory(vendingMachine);




            Console.WriteLine("Hello World!");
        }

        private static void fillUpInventory(VendingMachine vendingMachine)
        {
            List<ItemShelf> slots = vendingMachine.GetInventory().GetInventory();
            for (int i = 0; i < slots.Count; i++)
            {
                Item newItem = new Item();
                if (i >= 0 && i < 3)
                {
                    newItem.SetType(ItemType.COKE);
                    newItem.SetPrice(12);
                }
                else if (i >= 3 && i < 5)
                {
                    newItem.SetType(ItemType.PEPSI);
                    newItem.SetPrice(9);
                }
                else if (i >= 5 && i < 7)
                {
                    newItem.SetType(ItemType.JUICE);
                    newItem.SetPrice(13);
                }
                else if (i >= 7 && i < 10)
                {
                    newItem.SetType(ItemType.SODA);
                    newItem.SetPrice(7);
                }
                slots[i].Item = newItem;
                slots[i].IsSoldOut = false;
            }
        }
        static void displayInventory(VendingMachine vendingMachine)
        {
            List<ItemShelf> slots = vendingMachine.GetInventory().GetInventory();
            for (int i = 0; i < slots.Count; i++)
            {

                Console.WriteLine("CodeNumber: " + slots[i].Code +
                        " Item: " + slots[i].Item.GetItemType() +
                        " Price: " + slots[i].Item.GetPrice() +
                        " isAvailable: " + !slots[i].IsSoldOut);
            }


        }
    }
}
