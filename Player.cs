using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace test
{
    public class player : ModPlayer
    {
        public override void SetupStartInventory(IList<Item> items)
        {
            Item item = new Item();
            item.SetDefaults(mod.ItemType("Item1"));
            item.stack = 1;
            items.Add(item);
        }
    }
}