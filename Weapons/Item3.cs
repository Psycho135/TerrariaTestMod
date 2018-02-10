using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaTestMod.Weapons
{
    public class Item3 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Balanced Bow");
            Tooltip.SetDefault("Pretty good");
        }
        public override void SetDefaults()
        {
            item.damage = 50;
            item.ranged = true;
            item.width = 18;
            item.height = 18;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 6;
            item.value = 10000;
            item.rare = 2;
            item.shoot = 10;
            item.shootSpeed = 16f;
            item.autoReuse = true;
            item.useAmmo = AmmoID.Arrow;
            //item.shoot = mod.ProjectileType("ExampleBullet");
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "SpiritFlame");
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}