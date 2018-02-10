using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaTestMod
{
	class TerrariaTestMod : Mod
	{
		public TerrariaTestMod()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}

        public override void AddRecipeGroups()
        {
            RecipeGroup TinCopperGroup = new RecipeGroup(() => Lang.misc[37] + " Tin or Copper", new int[]
            {
                ItemID.TinBar,
                ItemID.CopperBar
            });
            RecipeGroup.RegisterGroup("Tin or Copper", TinCopperGroup);

            RecipeGroup SilverTungstenGroup = new RecipeGroup(() => Lang.misc[37] + " Silver or Tungsten", new int[]
            {
                ItemID.SilverBar,
                ItemID.TungstenBar
            });
            RecipeGroup.RegisterGroup("Silver or Tungsten", SilverTungstenGroup);

            RecipeGroup GoldPlatinumGroup = new RecipeGroup(() => Lang.misc[37] + " Gold or Platinum", new int[]
            {
                ItemID.GoldBar,
                ItemID.PlatinumBar
            });
            RecipeGroup.RegisterGroup("Gold or Platinum", GoldPlatinumGroup);
        }
    }
}
