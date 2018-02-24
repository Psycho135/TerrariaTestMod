using Terraria.ModLoader;
using Terraria.ID;


namespace TerrariaTestMod.Weapons
{
    public class TreeWand : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tree Wand");
            Tooltip.SetDefault("Crafted from the oldest branches of the World Tree.");
        }

        public override void SetDefaults()
        {
            item.damage = 20;
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
            item.shoot = mod.ProjectileType("TreeWandProjectile");
            item.shootSpeed = 8f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipeCor = new ModRecipe(mod);

            recipeCor.AddIngredient(mod, "SpiritFlame");
            recipeCor.AddIngredient(mod, "WoodenMagicRoot");
            recipeCor.AddIngredient(mod, "EbonwoodMagicRoot");
            recipeCor.AddIngredient(mod, "PalmWoodMagicRoot");
            recipeCor.AddIngredient(mod, "BorealWoodMagicRoot");
            recipeCor.AddIngredient(mod, "RichMahoganyMagicRoot");

            recipeCor.AddTile(TileID.WorkBenches);
            recipeCor.SetResult(this);
            recipeCor.AddRecipe();


            ModRecipe recipeCri = new ModRecipe(mod);

            recipeCri.AddIngredient(mod, "SpiritFlame");
            recipeCri.AddIngredient(mod, "WoodenMagicRoot");
            recipeCri.AddIngredient(mod, "ShadewoodMagicRoot");
            recipeCri.AddIngredient(mod, "PalmWoodMagicRoot");
            recipeCri.AddIngredient(mod, "BorealWoodMagicRoot");
            recipeCri.AddIngredient(mod, "RichMahoganyMagicRoot");

            recipeCri.AddTile(TileID.WorkBenches);
            recipeCri.SetResult(this);
            recipeCri.AddRecipe();
        }
    }
}
