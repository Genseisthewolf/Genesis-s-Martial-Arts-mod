using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Genepunch.Projectiles;
using Genepunch.Items;

namespace Genepunch.weapons
{
    internal class BeginnerFist : ModItem
    {

        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            DisplayName.SetDefault("Beginners' Fists");
            Tooltip.SetDefault("I could go one step farther If I wanted to.");
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
            Item.damage = 14;
            Item.knockBack = 2.1f;
            Item.crit = 3;

            Item.rare = ItemRarityID.Gray;
            Item.value = Item.buyPrice(copper: 5);

            Item.noUseGraphic = true;
            Item.noMelee = true;
           
            Item.shootSpeed = 2.1f;
            Item.shoot = ModContent.ProjectileType<BeginnerFistProjectile>();

         
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Gel, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }

       
        

    }


}
