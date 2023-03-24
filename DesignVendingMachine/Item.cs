namespace DesignVendingMachine
{
    public class Item
    {
        ItemType type;
        int price;

        public ItemType GetItemType()
        {
            return type;
        }

        public void SetType(ItemType type)
        {
            this.type = type;
        }

        public int GetPrice()
        {
            return price;
        }

        public void SetPrice(int price)
        {
            this.price = price;
        }

    }
}