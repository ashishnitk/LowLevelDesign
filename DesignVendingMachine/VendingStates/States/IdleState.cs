using System;
using System.Collections.Generic;
using System.Text;

namespace DesignVendingMachine.VendingStates.States
{
    public class IdleState : State
    {
        public IdleState()
        {
            Console.WriteLine("Currently Vending machine is in IdleState");
        }

        public IdleState(VendingMachine machine)
        {
            Console.WriteLine("Currently Vending machine is in IdleState");
            machine.SetCoinList(new List<Coin>());
        }

        public void ChooseProduct(VendingMachine machine, int codeNumber)
        {
            throw new Exception("you can not choose Product in idle state");
        }

        /// <summary>
        /// moving from Idle state to HasMoneyState
        /// </summary>
        /// <param name="machine"></param>
        public void ClickOnInsertCoinButton(VendingMachine machine)
        {
            machine.SetVendingMachineState(new HasMoneyState());
        }

        public void ClickOnStartProductSelectionButton(VendingMachine machine)
        {
            throw new Exception("first you need to click on insert coin button");
        }

        public Item DispenseProduct(VendingMachine machine, int codeNumber)
        {
            throw new Exception("you can not insert Coin in idle state");
        }

        public int GetChange(int returnChangeMoney)
        {
            throw new Exception("you can not get change in idle state");
        }

        public void InsertCoin(VendingMachine machine, Coin coin)
        {
            throw new Exception("you can not insert Coin in idle state");
        }

        public List<Coin> RefundFullMoney(VendingMachine machine)
        {
            throw new Exception("you can not get refunded in idle state");
        }

        public void UpdateInventory(VendingMachine machine, Item item, int codeNumber)
        {
            machine.GetInventory().AddItem(item, codeNumber);
        }
    }
}
