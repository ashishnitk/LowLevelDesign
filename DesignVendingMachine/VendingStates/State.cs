using System;
using System.Collections.Generic;
using System.Text;

namespace DesignVendingMachine.VendingStates
{
    public interface State
    {
        public void ClickOnInsertCoinButton(VendingMachine machine);

        public void ClickOnStartProductSelectionButton(VendingMachine machine);

        public void InsertCoin(VendingMachine machine, Coin coin);

        public void ChooseProduct(VendingMachine machine, int codeNumber);

        public int GetChange(int returnChangeMoney);

        public Item DispenseProduct(VendingMachine machine, int codeNumber);

        public List<Coin> RefundFullMoney(VendingMachine machine);

        public void UpdateInventory(VendingMachine machine, Item item, int codeNumber);

    }
}
