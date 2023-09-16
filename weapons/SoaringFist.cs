using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Genepunch.Projectiles;
using Genepunch.Items;

namespace Genepunch.weapons
{
    internal class SoaringFist : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            DisplayName.SetDefault("Soaring Fist");
            Tooltip.SetDefault("Kokode wa kōtō shinai");
        }

        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 28;
            Item.useStyle = ItemUseStyleID.Shoot;

            Item.DamageType = DamageClass.Ranged;
            Item.noMelee = true;
            Item.damage = 52;
            Item.knockBack = 3.1f;
            Item.crit = 2;

            Item.useTime = 25;
            Item.useAnimation = 20;

            Item.shoot = ModContent.ProjectileType<SoaringFistProjectile>();
            Item.shootSpeed = 2f;

            Item.rare = ItemRarityID.Blue;

        }



        public override void AddRecipes()
        {

            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Bone, 20);
            recipe.AddIngredient<DMedal>(2);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register(); 



        }
    }
}
