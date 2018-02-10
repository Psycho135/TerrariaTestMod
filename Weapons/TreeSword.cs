using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaTestMod.Weapons
{
    public class TreeSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tree Sword");
            Tooltip.SetDefault("Crafted from the hardest branches of wood.");
        }

        public override void SetDefaults()
        {
            item.damage = 25;
            item.melee = true;
            item.width = 18;
            item.height = 18;
            item.useTime = 60;
            item.useAnimation = 30;
            item.reuseDelay = 10;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 10000;
            item.rare = 2;
            item.autoReuse = true;
            item.useTurn = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipeCor = new ModRecipe(mod);

            recipeCor.AddIngredient(mod, "SpiritFlame");
            recipeCor.AddIngredient(ItemID.WoodenSword);
            recipeCor.AddIngredient(ItemID.EbonwoodSword);
            recipeCor.AddIngredient(ItemID.PalmWoodSword);
            recipeCor.AddIngredient(ItemID.BorealWoodSword);
            recipeCor.AddIngredient(ItemID.RichMahoganySword);

            recipeCor.AddTile(TileID.WorkBenches);
            recipeCor.SetResult(this);
            recipeCor.AddRecipe();


            ModRecipe recipeCri = new ModRecipe(mod);

            recipeCri.AddIngredient(mod, "SpiritFlame");
            recipeCri.AddIngredient(ItemID.WoodenSword);
            recipeCri.AddIngredient(ItemID.ShadewoodSword);
            recipeCri.AddIngredient(ItemID.PalmWoodSword);
            recipeCri.AddIngredient(ItemID.BorealWoodSword);
            recipeCri.AddIngredient(ItemID.RichMahoganySword);

            recipeCri.AddTile(TileID.WorkBenches);
            recipeCri.SetResult(this);
            recipeCri.AddRecipe();
        }
    }
}