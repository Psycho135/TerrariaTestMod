using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace TerrariaTestMod
{
    public class player : ModPlayer
    {
        public override void SetupStartInventory(IList<Item> items)
        {
            Item item = new Item();
            item.SetDefaults(mod.ItemType("Item1"));
            item.stack = 1;
            items.Add(item);

            Item item2 = new Item();
            item2.SetDefaults(ItemID.WoodenArrow);
            item2.stack = 999;
            items.Add(item2);
        }
    }
}