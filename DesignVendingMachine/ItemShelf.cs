using System;
using System.Collections.Generic;
using System.Text;

namespace DesignVendingMachine
{
    public class ItemShelf
    {
        public int Code { get; set; }
        public Item Item { get; set; }
        public bool IsSoldOut { get; set; }
    }
}
