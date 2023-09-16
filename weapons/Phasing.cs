using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Genepunch.Projectiles;

namespace Genepunch.weapons
{
    internal class Phasing : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            DisplayName.SetDefault("Phasing");
            Tooltip.SetDefault("I am the fastest");
        }
        public override void SetDefaults()
        {

            Item.width = 32;
            Item.height = 32;

            Item.useTime = 5;
            Item.useAnimation = 5;
            Item.autoReuse = true;
            Item.useStyle = ItemUseStyleID.Rapier;

            Item.UseSound = SoundID.Item1;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 100;
            Item.knockBack = 2.5f;
            Item.crit = 10;

            Item.rare = ItemRarityID.Yellow;
            Item.value = Item.buyPrice(silver: 25);

            Item.noUseGraphic = true;
            Item.noMelee = true;

            Item.shootSpeed = 2.1f;
            Item.shoot = ModContent.ProjectileType<PhasingProjectile>();

        }
    }
}
