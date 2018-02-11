using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaTestMod.Weapons
{
    public class Item3 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Abyss Bow");
            Tooltip.SetDefault("A precious metal fused with the essence of demons");
        }
        public override void SetDefaults()
        {
            item.damage = 24;
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
            ModRecipe recipePlDe = new ModRecipe(mod);
            recipePlDe.AddIngredient(ItemID.PlatinumBow);
            recipePlDe.AddIngredient(ItemID.DemonBow);
            recipePlDe.AddTile(TileID.Anvils);
            recipePlDe.SetResult(this);
            recipePlDe.AddRecipe();

            ModRecipe recipePlCr = new ModRecipe(mod);
            recipePlCr.AddIngredient(ItemID.PlatinumBow);
            recipePlCr.AddIngredient(ItemID.TendonBow);
            recipePlCr.AddTile(TileID.Anvils);
            recipePlCr.SetResult(this);
            recipePlCr.AddRecipe();

            ModRecipe recipeGlCr = new ModRecipe(mod);
            recipeGlCr.AddIngredient(ItemID.GoldBow);
            recipeGlCr.AddIngredient(ItemID.TendonBow);
            recipeGlCr.AddTile(TileID.Anvils);
            recipeGlCr.SetResult(this);
            recipeGlCr.AddRecipe();

            ModRecipe recipeGlDe = new ModRecipe(mod);
            recipeGlDe.AddIngredient(ItemID.GoldBow);
            recipeGlDe.AddIngredient(ItemID.DemonBow);
            recipeGlDe.AddTile(TileID.Anvils);
            recipeGlDe.SetResult(this);
            recipeGlDe.AddRecipe();
        }
    }
}