using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Genepunch.Items;
using Microsoft.Xna.Framework;
using tModPorter.Rewriters;
using Genepunch.Projectiles;

namespace Genepunch.weapons
{
    internal class ClashStrike : ModItem
    {


        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            DisplayName.SetDefault("Step");
            Tooltip.SetDefault("Sometimes called vansishing");
        }
        public override void SetDefaults()
        {

            Item.width = 32;
            Item.height = 32;

            Item.useTime = 22;
            Item.useAnimation = 22;
            Item.autoReuse = false;
            Item.useStyle = ItemUseStyleID.Rapier;

            Item.UseSound = SoundID.Item1;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 0;
            Item.knockBack = 0f;
            

            Item.rare = ItemRarityID.Yellow;
            Item.value = Item.buyPrice(silver: 25);

            Item.noUseGraphic = true;
            Item.noMelee = true;

            Item.shootSpeed = 2.1f;
            Item.shoot = ModContent.ProjectileType<BeginnerFistProjectile>();

        }

        public override bool? UseItem(Player player)
        {

            player.velocity.X = -10f * player.direction;
            return null;
        }


    }
}
