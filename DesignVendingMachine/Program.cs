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

            Console.WriteLine("fillingup the vending machine");
            fillupVendingMachine(vendingMachine);
            displayVendingMachine(vendingMachine);

            Console.WriteLine("|");
            Console.WriteLine("click on InsertCoinButton");
            Console.WriteLine("|");

            State vendingState = vendingMachine.GetVendingMachineState();
            vendingState.ClickOnInsertCoinButton(vendingMachine);

            vendingState = vendingMachine.GetVendingMachineState();

            vendingState.InsertCoin(vendingMachine, Coin.NICKEL);
            // vendingState.InsertCoin(vendingMachine, Coin.DIME);

            Console.WriteLine("|");
            Console.WriteLine("click on ProdcutSelection");
            Console.WriteLine("|");

            vendingState.ClickOnStartProductSelectionButton(vendingMachine);
            vendingState = vendingMachine.GetVendingMachineState();

            vendingState.ChooseProduct(vendingMachine, 102);

            displayVendingMachine(vendingMachine);

            Console.WriteLine("Hello World!");
        }

        private static void displayVendingMachine(VendingMachine vendingMachine)
        {
            List<ItemShelf> slots = vendingMachine.GetInventory().GetInventory1();
            for (int i = 0; i < slots.Count; i++)
            {
                Console.WriteLine("CodeNumber: " + slots[i].Code + " Item: " + slots[i].Item.GetItemType() + " Price: " + slots[i].Item.GetPrice() + " IsSoldOut: " + slots[i].IsSoldOut);

            }
        }

        private static void fillupVendingMachine(VendingMachine vendingMachine)
        {
            List<ItemShelf> slots = vendingMachine.GetInventory().GetInventory1();

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
                    newItem.SetPrice(5);
                }
                else if (i >= 5 && i < 7)
                {
                    newItem.SetType(ItemType.JUICE);
                    newItem.SetPrice(9);
                }
                else if (i >= 7 && i < 10)
                {
                    newItem.SetType(ItemType.SODA);
                    newItem.SetPrice(20);
                }
                slots[i].Item = newItem;
                slots[i].IsSoldOut = false;
            }

        }
    }
}
