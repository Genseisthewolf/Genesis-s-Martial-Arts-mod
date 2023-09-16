using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Genepunch.Items
{
    internal class EssenceofSpeed : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Essence of Speed");
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
