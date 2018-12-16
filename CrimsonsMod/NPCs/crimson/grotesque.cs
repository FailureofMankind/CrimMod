using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.NPCs.crimson
{
	// This ModNPC serves as an example of a complete AI example.
	public class grotesque : ModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Flutter Slime"); // Automatic from .lang files
			DisplayName.SetDefault("Grotesque Slime");
			Main.npcFrameCount[npc.type] = 2; // make sure to set this for your modnpcs.
		}

		public override void SetDefaults()
		{
			npc.width = 44;
			npc.height = 40;
			animationType = 1;
			npc.aiStyle = 1;
			npc.damage = 8;
			npc.defense = 3;
			npc.lifeMax = 70;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			//npc.alpha = 175;
			//npc.color = new Color(0, 80, 255, 100);
			npc.value = 25f; // npc default to being immune to the Confused debuff. Allowing confused could be a little more work depending on the AI. npc.confused is true while the npc is confused.
		}
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			if(spawnInfo.player.ZoneCrimson && !Main.hardMode)
			{
				return 0.3f;
			}			
			return 0f;
		}

	}
}
