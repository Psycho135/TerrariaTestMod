using Terraria.ModLoader;
using Terraria.ID;


namespace TerrariaTestMod.Weapons
{
    public class ShadewoodMagicRoot : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shade Magic Root");
            Tooltip.SetDefault("The source of nourishment for all trees.");
        }

        public override void SetDefaults()
        {
            item.damage = 12;
            item.magic = true;
            item.width = 18;
            item.height = 8;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 1;
            item.noMelee = true;
            item.knockBack = 2;
            item.value = 50;
            item.rare = 1;
            item.mana = 5;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("MagicRootProjectile");
            item.shootSpeed = 6f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Shadewood, 8);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
