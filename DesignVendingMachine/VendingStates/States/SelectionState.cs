using System;
using System.Collections.Generic;
using System.Text;

namespace DesignVendingMachine.VendingStates.States
{
    class SelectionState : State
    {
        public SelectionState()
        {
            Console.WriteLine("Currently Vending machine is in SelectionState");
        }
        public void ChooseProduct(VendingMachine machine, int codeNumber)
        {
            //1. get item of this codeNumber
            Item item = machine.GetInventory().GetItem(codeNumber);

            //2. total amount paid by User
            int paidByUser = 0;
            foreach (var itm in machine.GetCoinList())
            {
                paidByUser = paidByUser+ ((int)itm);
            }

            //3. compare product price and amount paid by user
            if (paidByUser < item.GetPrice())
            {
                Console.WriteLine("Insufficient Amount, Product you selected is for price: " + item.GetPrice() + " and you paid: " + paidByUser);
                RefundFullMoney(machine);
                throw new Exception("insufficient amount");
            }
            else if (paidByUser >= item.GetPrice())
            {

                if (paidByUser > item.GetPrice())
                {
                    GetChange(paidByUser - item.GetPrice());
                }
                machine.SetVendingMachineState(new DispenseState(machine, codeNumber));
            }
        }

        public void ClickOnInsertCoinButton(VendingMachine machine)
        {
            throw new Exception("you can not click on insert coin button in Selection state");
        }

        public void ClickOnStartProductSelectionButton(VendingMachine machine)
        {
            return;
        }

        public Item DispenseProduct(VendingMachine machine, int codeNumber)
        {
            throw new Exception("product can not be dispensed Selection state");
        }

        public int GetChange(int returnExtraMoney)
        {
            //actual logic should be to return COINs in the dispense tray, but for simplicity i am just returning the amount to be refunded
            Console.WriteLine("Returned the change in the Coin Dispense Tray: " + returnExtraMoney);
            return returnExtraMoney;
        }

        public void InsertCoin(VendingMachine machine, Coin coin)
        {
            throw new Exception("you can not insert Coin in selection state");
        }

        public List<Coin> RefundFullMoney(VendingMachine machine)
        {
            Console.WriteLine("Returned the full amount back in the Coin Dispense Tray");
            machine.SetVendingMachineState(new IdleState(machine));
            return machine.GetCoinList();
        }

        public void UpdateInventory(VendingMachine machine, Item item, int codeNumber)
        {
            throw new Exception("Inventory can not be updated in Selection state");
        }
    }
}
