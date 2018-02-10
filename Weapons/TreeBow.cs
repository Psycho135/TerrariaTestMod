using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaTestMod.Weapons
{
    public class TreeBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tree Bow");
            Tooltip.SetDefault("Crafted from the lightest branches of wood.");
        }

        public override void SetDefaults()
        {
            item.damage = 25;
            item.ranged = true;
            item.width = 9;
            item.height = 22;
            item.useTime = 30;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 6;
            item.value = 10000;
            item.rare = 2;
            item.autoReuse = true;
            item.shoot = 10;
            item.shootSpeed = 10f;
            item.useAmmo = AmmoID.Arrow;
        }

        public override void AddRecipes()
        {
            ModRecipe recipeCor = new ModRecipe(mod);

            recipeCor.AddIngredient(mod, "SpiritFlame");
            recipeCor.AddIngredient(ItemID.WoodenBow);
            recipeCor.AddIngredient(ItemID.EbonwoodBow);
            recipeCor.AddIngredient(ItemID.PalmWoodBow);
            recipeCor.AddIngredient(ItemID.BorealWoodBow);
            recipeCor.AddIngredient(ItemID.RichMahoganyBow);

            recipeCor.AddTile(TileID.WorkBenches);
            recipeCor.SetResult(this);
            recipeCor.AddRecipe();


            ModRecipe recipeCri = new ModRecipe(mod);

            recipeCri.AddIngredient(mod, "SpiritFlame");
            recipeCri.AddIngredient(ItemID.WoodenBow);
            recipeCri.AddIngredient(ItemID.ShadewoodBow);
            recipeCri.AddIngredient(ItemID.PalmWoodBow);
            recipeCri.AddIngredient(ItemID.BorealWoodBow);
            recipeCri.AddIngredient(ItemID.RichMahoganyBow);

            recipeCri.AddTile(TileID.WorkBenches);
            recipeCri.SetResult(this);
            recipeCri.AddRecipe();
        }
    }
}
