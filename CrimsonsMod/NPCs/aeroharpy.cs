using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.NPCs
{
	// This ModNPC serves as an example of a complete AI example.
	public class aeroharpy : ModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Flutter Slime"); // Automatic from .lang files
			DisplayName.SetDefault("Aero Harpy");
			Main.npcFrameCount[npc.type] = 4; // make sure to set this for your modnpcs.
		}

		public override void SetDefaults()
		{
			npc.width = 32;
			npc.height = 32;
			animationType = 48;			
			npc.aiStyle = 14; // This npc has a completely unique AI, so we set this to -1.
			npc.damage = 8;
			npc.defense = 3;
			npc.lifeMax = 60;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			//npc.alpha = 175;
			//npc.color = new Color(0, 80, 255, 100);
			npc.value = 25f; // npc default to being immune to the Confused debuff. Allowing confused could be a little more work depending on the AI. npc.confused is true while the npc is confused.
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			// we would like this npc to spawn in the overworld.
			if(spawnInfo.player.ZoneSkyHeight && MyWorld.aero_aggression == true)
			{
				return 0.4f; //basically chance for spwn
			}			
			return 0f; //need to put this because "your code has a chance to not return a value"
		}
	}
}
