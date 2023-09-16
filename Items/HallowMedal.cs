using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Genepunch.Items
{
    internal class HallowMedal : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hallowed Medal");
            Tooltip.SetDefault("It feels hallow");
        }
        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;

            Item.value = Item.buyPrice(copper: 5);
            Item.maxStack = 999;
        }
    }
}
