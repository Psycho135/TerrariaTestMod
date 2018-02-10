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
            item.SetDefaults(mod.ItemType("SpiritFlame"));
            item.stack = 1;
            items.Add(item);
        }
    }
}