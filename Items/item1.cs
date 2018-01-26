using Terraria.ID;
using Terraria.ModLoader;

namespace test.Items
{
	public class Item1 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Item1");
			Tooltip.SetDefault("starting material");
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