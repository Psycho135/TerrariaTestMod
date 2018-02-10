using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaTestMod.Weapons
{
    public class Item4 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Balanced Book");
            Tooltip.SetDefault("Pretty good");
        }
        public override void SetDefaults()
        {
            item.damage = 50;
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
            recipe.AddIngredient(mod, "SpiritFlame");
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}