using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.NPCs.crimson.postml
{
	// This ModNPC serves as an example of a complete AI example.
	public class pus_clot : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pus Clot");
		}

		public override void SetDefaults()
		{
			npc.width = 48;
			npc.height = 48;
			animationType = 48;			
			npc.aiStyle = 14; // This npc has a completely unique AI, so we set this to -1.
			npc.damage = 120;
			npc.defense = 20;
			npc.knockBackResist = 0f;
			
			npc.lifeMax = 1600;
			npc.HitSound = SoundID.NPCHit8;
			npc.DeathSound = SoundID.NPCDeath28;
			//npc.alpha = 175;
			//npc.color = new Color(0, 80, 255, 100);
			npc.value = 25f; // npc default to being immune to the Confused debuff. Allowing confused could be a little more work depending on the AI. npc.confused is true while the npc is confused.
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			if(spawnInfo.player.ZoneCrimson && spawnInfo.downedMoonlord == true)
			{
				return 0.2f;
			}			
			return 0f;
		}
	}
}
