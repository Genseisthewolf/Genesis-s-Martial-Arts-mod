using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Genepunch.Items;

namespace Genepunch.weapons
{
    internal class MeteorCrusher : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Meteor Crusher");
            Tooltip.SetDefault("And this is how to go one step beyond");
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
            Item.damage = 55;
            Item.knockBack = 20f;
            Item.crit = 6;

            Item.value = Item.buyPrice(silver: 15);
            Item.rare = ItemRarityID.Blue;


        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Bone, 20);
            recipe.AddIngredient<MeteorSledge>(1);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}
