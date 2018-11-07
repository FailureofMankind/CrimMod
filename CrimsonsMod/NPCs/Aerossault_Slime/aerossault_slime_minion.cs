using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.NPCs.Aerossault_Slime
{
	// This ModNPC serves as an example of a complete AI example.
	public class aerossault_slime_minion : ModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Flutter Slime"); // Automatic from .lang files
			DisplayName.SetDefault("Aero Slime");
			Main.npcFrameCount[npc.type] = 4; // make sure to set this for your modnpcs.
		}

		public override void SetDefaults()
		{
			npc.width = 32;
			npc.height = 32;
			animationType = 48;
			npc.aiStyle = 14;
			npc.damage = 30;
			npc.defense = 5;
			npc.lifeMax = 30;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			//npc.alpha = 175;
			//npc.color = new Color(0, 80, 255, 100);
			npc.value = 0f; 
		}
	}
}
