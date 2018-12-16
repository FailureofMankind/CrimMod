using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CrimsonsMod.NPCs;

namespace CrimsonsMod.Buffs
{
	public class crystal_crush : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Crystal Crushed");
			Description.SetDefault("The crystals corrode your skin...");
			Main.debuff[Type] = true;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
			longerExpertDebuff = true;
		}

        /*public override void Update(Player player, ref int buffIndex)
        {
			player.GetModPlayer<CrimsonPlayer>().crystalCrush = true;
		}*/

		public override void Update(NPC npc, ref int buffIndex)
        {
			npc.GetGlobalNPC<ModGlobalNPC>().crystalCrush = true;
        }
    }
}