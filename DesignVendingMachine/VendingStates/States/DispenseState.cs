using System;
using System.Collections.Generic;
using System.Text;

namespace DesignVendingMachine.VendingStates.States
{
    public class DispenseState : State
    {
        public DispenseState(VendingMachine machine, int codeNumber)
        {
            Console.WriteLine("Currently Vending machine is in DispenseState");
            DispenseProduct(machine, codeNumber);

        }
        public void ChooseProduct(VendingMachine machine, int codeNumber)
        {
            throw new NotImplementedException();
        }

        public void ClickOnInsertCoinButton(VendingMachine machine)
        {
            throw new Exception("insert coin button can not clicked on Dispense state");
        }

        public void ClickOnStartProductSelectionButton(VendingMachine machine)
        {
            throw new Exception("product selection buttion can not be clicked in Dispense state");
        }

        public Item DispenseProduct(VendingMachine machine, int codeNumber)
        {
            Console.WriteLine("Product has been dispensed");
            Item item = machine.GetInventory().GetItem(codeNumber);
            machine.GetInventory().UpdateSoldOutItem(codeNumber);
            machine.SetVendingMachineState(new IdleState(machine));
            return item;
        }

        public int GetChange(int returnChangeMoney)
        {
            throw new Exception("change can not returned in Dispense state");
        }

        public void InsertCoin(VendingMachine machine, Coin coin)
        {
            throw new Exception("coin can not be inserted in Dispense state");
        }

        public List<Coin> RefundFullMoney(VendingMachine machine)
        {
            throw new Exception("refund can not be happen in Dispense state");
        }

        public void UpdateInventory(VendingMachine machine, Item item, int codeNumber)
        {
            throw new Exception("inventory can not be updated in Dispense state");
        }
    }
}
