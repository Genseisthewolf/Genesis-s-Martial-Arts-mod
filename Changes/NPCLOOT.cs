using System;
using Terraria.ID;
using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader;
using Terraria;

namespace Genepunch.Changes
{
    internal class NPCLOOT : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.EyeofCthulhu)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.EssenceofSpeed>(), 3/10,  1, 10));
            }

            if (npc.type == NPCID.SkeletronPrime)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.HallowMedal>(), 3/10, 1, 5));
            }

            if (npc.type == NPCID.SkeletronPrime)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<weapons.Phasing>(), 5 / 100, 1, 1));
            }

            if (npc.type == NPCID.EyeofCthulhu)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<weapons.ClashStrike>(), 15 / 100, 1, 1));
            }

            if (npc.type == NPCID.SkeletronHead)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<weapons.ClashStrike>(), 15 / 100, 1, 1));
            }

            
        }

    }
}
