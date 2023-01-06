using System.Collections.Generic;
using GildedRose.Items;

namespace GildedRose
{
    public class Shop
    {
        public IList<Item> Items {get; private set; }

        public Shop(IList<Item> items)
        {
            this.Items = items;
        }

        public void UpdateQuality()
        {
            foreach (Item item in this.Items)
            {
                item.Update();
            }
        }

    }
}    
