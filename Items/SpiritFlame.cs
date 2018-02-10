using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaTestMod.Items
{
	public class SpiritFlame : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spirit Flame");
			Tooltip.SetDefault("The essence of life.");
		}

		public override void SetDefaults()
		{
			item.width = 13;
			item.height = 18;
			item.useTime = 5;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.value = 10;
			item.rare = 0;
		}
    }
}