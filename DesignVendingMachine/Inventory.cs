using System;
using System.Collections.Generic;
using System.Text;

namespace DesignVendingMachine
{
    public class Inventory
    {
        List<ItemShelf> inventory = null;
        public Inventory(int count)
        {
            inventory = new List<ItemShelf>();
            InitialEmptyInventory(count);
        }
        public List<ItemShelf> GetInventory1()
        {
            return inventory;
        }

        public void SetInventory(List<ItemShelf> inventory)
        {
            this.inventory = inventory;
        }

        private void InitialEmptyInventory(int count)
        {
            int startCode = 101;
            // for (int i = 0; i < inventory.Count; i++)
            for (int i = 0; i < count; i++)
            {
                ItemShelf space = new ItemShelf();
                space.Code = startCode;
                space.IsSoldOut = true;
                inventory.Add(space);
                startCode++;
            }
        }

        public void AddItem(Item item, int codeNumber)
        {
            int num = inventory.FindIndex(a => a.Code == codeNumber);
            if (num > -1)
            {

            }
            else
            {
                inventory.Add(new ItemShelf() { Code = codeNumber, IsSoldOut = false, Item = item });
            }
        }

        public Item GetItem(int codeNumber)
        {
            int num = inventory.FindIndex(a => a.Code == codeNumber);
            if (num > -1)
            {
                return inventory[num].Item;
            }
            else
            {
                throw new Exception("Invalid code!");
            }
        }

        public void UpdateSoldOutItem(int codeNumber)
        {
            int num = inventory.FindIndex(a => a.Code == codeNumber);
            if (num > -1)
            {
                inventory[num].IsSoldOut = true;
            }
            else
            {
                throw new Exception("Invalid code!");
            }
        }
    }
}
