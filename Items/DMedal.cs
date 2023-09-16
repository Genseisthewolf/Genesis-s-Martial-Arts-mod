using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.ItemDropRules;
using Genepunch.weapons;

namespace Genepunch.Items
{
    internal class DMedal : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("D Medal");
            Tooltip.SetDefault("A medal?");
        }
        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;

            Item.value = Item.buyPrice(copper: 5);
            Item.maxStack = 999;
            Item.rare = ItemRarityID.Green;




        }



        public override void AddRecipes()
        {
            
            Recipe  recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.TissueSample, 5);
            recipe.AddIngredient(ItemID.Gel, 25);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();

            Recipe recipe1 = CreateRecipe();
            recipe1.AddIngredient(ItemID.ShadowScale, 5);
            recipe1.AddIngredient(ItemID.Gel, 25);
            recipe1.AddTile(TileID.WorkBenches);
            recipe1.Register();
             
            
        }



    }
       
}
        
   






