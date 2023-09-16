using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Genepunch.Items;

namespace Genepunch.weapons
{
    internal class MeteorSledge : ModItem
    {


        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Meteor Sledge");
            Tooltip.SetDefault("The halmark of any warrior");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {

            Item.width = 32;
            Item.height = 32;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 45;
            Item.useAnimation = 45;

            Item.UseSound = SoundID.Item1;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 30;
            Item.knockBack = 14f;
            Item.crit = 5;

            Item.value = Item.buyPrice(silver: 15);
            Item.rare = ItemRarityID.Green;






        }



        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.TissueSample, 15);
            recipe.AddIngredient<DMedal>(15);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();

            Recipe recipe1 = CreateRecipe();
            recipe1.AddIngredient(ItemID.ShadowScale, 15);
            recipe1.AddIngredient<DMedal>(15);
            recipe1.AddTile(TileID.WorkBenches);
            recipe1.Register();
        }

    }


}
