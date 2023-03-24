using DesignVendingMachine.VendingStates.States;
using System.Collections.Generic;

namespace DesignVendingMachine.VendingStates
{
    public class VendingMachine
    {
        private State vendingMachineState;
        private Inventory inventory;
        private List<Coin> coinList;

        public VendingMachine(int NumberOfItems)
        {
            vendingMachineState = new IdleState();
            inventory = new Inventory(NumberOfItems);
            coinList = new List<Coin>();
        }

        public State GetVendingMachineState()
        {
            return vendingMachineState;
        }

        public void SetVendingMachineState(State vendingMachineState)
        {
            this.vendingMachineState = vendingMachineState;
        }

        public Inventory GetInventory()
        {
            return inventory;
        }

        public void SetInventory(Inventory inventory)
        {
            this.inventory = inventory;
        }

        public List<Coin> GetCoinList()
        {
            return coinList;
        }

        public void SetCoinList(List<Coin> coinList)
        {
            this.coinList = coinList;
        }



    }
}