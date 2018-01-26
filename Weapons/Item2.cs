using Terraria.ID;
using Terraria.ModLoader;

namespace test.Items
{
    public class Item2 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Balanced Sword");
            Tooltip.SetDefault("Pretty good");
        }
        public override void SetDefaults()
        {
            item.damage = 50;
            item.melee = true;
            item.width = 18;
            item.height = 18;
            item.useTime = 5;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 10000;
            item.rare = 2;
            item.autoReuse = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "Item1");
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}