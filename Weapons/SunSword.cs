using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaTestMod.Weapons
{
    public class SunSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sun Sword");
            Tooltip.SetDefault("A sword that emits a powerful light.");
        }

        public override void SetDefaults()
        {
            item.damage = 27;
            item.melee = true;
            item.width = 18;
            item.height = 18;
            item.useTime = 25;
            item.useAnimation = 30;
            item.reuseDelay = 10;
            item.useStyle = 1;
            item.knockBack = 2;
            item.value = 10000;
            item.rare = 2;
            item.autoReuse = true;
            item.useTurn = true;
            item.shoot = mod.ProjectileType("SunSwordProjectile");
            item.shootSpeed = 8f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe1 = new ModRecipe(mod);
            recipe1.AddIngredient(ItemID.GoldBroadsword);
            recipe1.AddIngredient(ItemID.Cloud,20);
            recipe1.AddIngredient(ItemID.SunplateBlock, 25);
            recipe1.AddRecipeGroup("Gold or Platinum", 20);

            recipe1.AddTile(TileID.SkyMill);
            recipe1.SetResult(this);
            recipe1.AddRecipe();

            ModRecipe recipe2 = new ModRecipe(mod);
            recipe2.AddIngredient(ItemID.PlatinumBroadsword);
            recipe2.AddIngredient(ItemID.Cloud, 20);
            recipe2.AddIngredient(ItemID.SunplateBlock, 25);
            recipe2.AddRecipeGroup("Gold or Platinum", 20);

            recipe2.AddTile(TileID.SkyMill);
            recipe2.SetResult(this);
            recipe2.AddRecipe();
        }
    }
}