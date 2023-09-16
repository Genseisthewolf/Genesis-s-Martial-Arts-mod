using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Genepunch.Projectiles;
using Genepunch.Items;

namespace Genepunch.weapons
{
    internal class SpeedPunch : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            DisplayName.SetDefault("Speed Punch");
            Tooltip.SetDefault("Run Barry Run");
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
            Item.damage = 30;
            Item.knockBack = 2.5f;

            Item.rare = ItemRarityID.Green;
            Item.value = Item.buyPrice(silver: 35);

            Item.noUseGraphic = true;
            Item.noMelee = true;

            Item.shootSpeed = 2.1f;
            Item.shoot = ModContent.ProjectileType<SpeedPunchProjectile>();
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<VialofSpeed>(1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();

        }
    }
}
