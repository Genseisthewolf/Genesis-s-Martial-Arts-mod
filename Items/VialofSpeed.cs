using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Genepunch.Items
{
    internal class VialofSpeed : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vial of Speedforce");
           
        }
        public override void SetDefaults() 
        {

            Item.width = 16;
            Item.height = 16;

            Item.value = Item.buyPrice(copper: 5);
            Item.maxStack = 999;
        }

        public override void AddRecipes()
        {

            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.MeteoriteBar, 2);
            recipe.AddIngredient<EssenceofSpeed>(5);
            recipe.AddTile(TileID.Bottles);
            recipe.Register();
        }
    }
}
