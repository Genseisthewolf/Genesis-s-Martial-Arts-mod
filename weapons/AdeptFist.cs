using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Genepunch.Projectiles;
using Genepunch.Items;

namespace Genepunch.weapons
{
    internal class AdeptFist : ModItem
    {

        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            DisplayName.SetDefault("Adept Fists");
            Tooltip.SetDefault("I've had my fill of bad futures");

        }

        public override void SetDefaults() 
        {

            Item.width = 32;
            Item.height = 32;

            Item.useTime = 10;
            Item.useAnimation = 10;
            Item.autoReuse = true;
            Item.useStyle = ItemUseStyleID.Rapier;

            Item.UseSound = SoundID.Item1;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 52;
            Item.knockBack = 2.5f;

            Item.rare = ItemRarityID.Blue;
            Item.value = Item.buyPrice(silver: 25);

            Item.noUseGraphic = true;
            Item.noMelee = true;

            Item.shootSpeed = 2.1f;
            Item.shoot = ModContent.ProjectileType<AdpetFistProjectile>();

        }

        public override void AddRecipes() 
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<DMedal>(20);
            recipe.AddIngredient(ItemID.Bone, 50);
            recipe.AddIngredient<IntermediateFist>();
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }




    }

   
}