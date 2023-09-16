using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Genepunch.Projectiles;
using Genepunch.Items;


namespace Genepunch.weapons
{
    internal class ExpertFist : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            DisplayName.SetDefault("Expert Fists");
            Tooltip.SetDefault("You may have invaded my mind and my body, but there's one thing a Saiyan always keeps: his pride");
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;

            Item.useTime = 14;
            Item.useAnimation = 14;
            Item.useStyle = ItemUseStyleID.Rapier;
            Item.autoReuse = true;

            Item.UseSound = SoundID.Item1;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 78;
            Item.knockBack = 3f;
            Item.crit = 6;

            Item.rare = ItemRarityID.LightPurple;
            Item.value = Item.buyPrice(copper: 5);

            Item.noUseGraphic = true;
            Item.noMelee = true;

            Item.shootSpeed = 2.1f;
            Item.shoot = ModContent.ProjectileType<BeginnerFistProjectile>();
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<HallowMedal>(5);
            recipe.AddIngredient<AdeptFist>(1);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}
