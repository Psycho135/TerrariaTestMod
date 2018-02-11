using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaTestMod.Weapons
{
    public class Item4 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Abyss Book");
            Tooltip.SetDefault("A book that contains magic of the underworld");
        }
        public override void SetDefaults()
        {
            item.damage = 21;
            item.magic = true;
            item.width = 18;
            item.height = 18;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 2;
            item.value = 10000;
            item.rare = 2;
            item.mana = 5;
            item.autoReuse = true;
           // item.UseSound = 21;
            item.shoot = mod.ProjectileType("Item4Projectile");
            item.shootSpeed = 8f;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WaterBolt);
            recipe.AddRecipeGroup("Demonite or Crimtane", 10);
            recipe.AddTile(TileID.Bookcases);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}