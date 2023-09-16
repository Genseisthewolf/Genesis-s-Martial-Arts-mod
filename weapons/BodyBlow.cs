using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Genepunch.Projectiles;
using Genepunch.Items;

namespace Genepunch.weapons
{
    internal class BodyBlow : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            DisplayName.SetDefault("Body Blow");
            Tooltip.SetDefault("It Is No Sin To Fight For What Is Right");
        }
        public override void SetDefaults() 
        {
            Item.width = 32;
            Item.height = 32;

            Item.useTime = 45;
            Item.useAnimation = 45;
            Item.useStyle = ItemUseStyleID.Rapier;

            Item.UseSound = SoundID.Item1;

            Item.DamageType = DamageClass.MeleeNoSpeed;
            Item.damage = 25;
            Item.knockBack = 2.5f;
            Item.crit = 5;

            Item.rare = ItemRarityID.Green;
            Item.value = Item.buyPrice(silver: 20);

            Item.noUseGraphic = true;
            Item.noMelee = true;

            Item.shootSpeed = 2.1f;
            Item.shoot = ModContent.ProjectileType<BodyBlowProjectile>();
        }


        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
           
            target.AddBuff(BuffID.Frozen, 300);
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<DMedal>(10);
            recipe.AddIngredient(ItemID.TissueSample, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();

            Recipe recipe1 = CreateRecipe();
            recipe1.AddIngredient<DMedal>(10);
            recipe1.AddIngredient(ItemID.ShadowScale, 10);
            recipe1.AddTile(TileID.WorkBenches);
            recipe1.Register();
        }

    }

}
