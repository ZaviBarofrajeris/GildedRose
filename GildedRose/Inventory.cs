using System.Collections.Generic;

namespace GildedRose
{
    class Inventory
    {
        private readonly IEnumerable<Item> items;

        public Inventory(IEnumerable<Item> items)
        {
            this.items = items;
        }

        /// <summary>
        /// Items:
        /// "+5 Dexterity Vest"
        /// "Aged Brie"
        /// "Elixir of the Mongoose"
        /// "Sulfuras, Hand of Ragnaros"
        /// "Backstage passes to a TAFKAL80ETC concert"
        /// "Conjured Mana Cake"
        /// </summary>
        public void UpdateQuality()
        {
            // TODO ...

            // Hint: Iterate through this.items and check Name property to access specific item
            foreach (var item in items)
            {
                if (item.SellIn > 0 && item.Name != "Aged Brie" && item.Name != "Sulfuras, Hand of Ragnaros" && item.Name != "Backstage passes to a TAFKAL80ETC concert" && item.Name != "Conjured Mana Cake")
                {
                    item.Quality -= 1;
                }
                else if (item.SellIn <= 0 && item.Name != "Aged Brie" && item.Name != "Sulfuras, Hand of Ragnaros" && item.Name != "Backstage passes to a TAFKAL80ETC concert" && item.Name != "Conjured Mana Cake")
                {
                    item.Quality -= 2;
                }
                else if (item.Name == "Aged Brie" && item.SellIn > 0)
                {
                    item.Quality += 1;
                }
                else if (item.Name == "Aged Brie" && item.SellIn <= 0)
                {
                    item.Quality += 2;
                }
                else if (item.Name == "Conjured Mana Cake" && item.SellIn > 0)
                {
                    item.Quality -= 2;
                }
                else if (item.Name == "Conjured Mana Cake" && item.SellIn <= 0)
                {
                    item.Quality -= 4;
                }
                else if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (item.SellIn > 10)
                    {
                        item.Quality += 1;
                    }
                    else if (item.SellIn > 5 && item.SellIn <= 10)
                    {
                        item.Quality += 2;
                    }
                    else if (item.SellIn > 0 && item.SellIn <= 5)
                    {
                        item.Quality += 3;
                    }
                    else if (item.SellIn <= 0)
                    {
                        item.Quality = 0;
                    }

                }




                if (item.Quality < 0) //&& //||
                {
                    item.Quality = 0;
                }
                if (item.Quality > 50 && item.Name != "Sulfuras, Hand of Ragnaros")
                {
                    item.Quality = 50;
                }
                if (item.Name != "Sulfuras, Hand of Ragnaros")
                {
                    item.SellIn -= 1;
                }


            }
        }
    }
}
