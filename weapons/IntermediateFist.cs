using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Genepunch.Projectiles;
using Terraria.Localization;
using Genepunch.weapons;
using Genepunch.Items;

namespace Genepunch.weapons
{
    internal class IntermediateFist : ModItem
    {

        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            DisplayName.SetDefault("Intermediate Fists");
            Tooltip.SetDefault("Badabadum BINGO!!");

        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;

            Item.useTime = 12;
            Item.useAnimation = 12;
            Item.useStyle = ItemUseStyleID.Rapier;
            Item.autoReuse = true;

            Item.UseSound = SoundID.Item1;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 28;
            Item.knockBack = 2f;

            Item.rare = ItemRarityID.Green;
            Item.value = Item.buyPrice(silver: 5);

            Item.noUseGraphic = true;
            Item.noMelee = true;

            Item.shootSpeed = 2.1f;
            Item.shoot = ModContent.ProjectileType<IntermediateFistProjectile>();
        }

        public override void AddRecipes()
        {

            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.TissueSample, 15);
            recipe.AddIngredient<DMedal>(10);
            recipe.AddIngredient<BeginnerFist>();
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();

            Recipe recipe1 = CreateRecipe();
            recipe1.AddIngredient(ItemID.ShadowScale, 15);
            recipe1.AddIngredient<DMedal>(10);
            recipe1.AddIngredient<BeginnerFist>();
            recipe1.AddTile(TileID.WorkBenches);
            recipe1.Register();
        }





    }


}
