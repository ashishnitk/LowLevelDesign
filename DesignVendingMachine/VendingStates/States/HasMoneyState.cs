using System;
using System.Collections.Generic;
using System.Text;

namespace DesignVendingMachine.VendingStates.States
{
    public class HasMoneyState : State
    {
        public HasMoneyState()
        {
            Console.WriteLine("Currently Vending machine is in HasMoneyState");
        }
        public void ChooseProduct(VendingMachine machine, int codeNumber)
        {
            throw new NotImplementedException();
        }

        public void ClickOnInsertCoinButton(VendingMachine machine)
        {
            return;
        }

        public Item DispenseProduct(VendingMachine machine, int codeNumber)
        {
            throw new Exception("product can not be dispensed in hasMoney state");
        }

        public int GetChange(int returnChangeMoney)
        {
            throw new Exception("you can not get change in hasMoney state");
        }

        public void InsertCoin(VendingMachine machine, Coin coin)
        {
            Console.WriteLine("Accepted the coin");
            machine.GetCoinList().Add(coin);
        }

        public void ClickOnStartProductSelectionButton(VendingMachine machine)
        {
            machine.SetVendingMachineState(new SelectionState());
        }

        public List<Coin> RefundFullMoney(VendingMachine machine)
        {
            Console.WriteLine("Returned the full amount back in the Coin Dispense Tray");
            machine.SetVendingMachineState(new IdleState(machine));
            return machine.GetCoinList();
        }

        public void UpdateInventory(VendingMachine machine, Item item, int codeNumber)
        {
            throw new Exception("you can not update inventory in hasMoney  state");
        }
    }
}
