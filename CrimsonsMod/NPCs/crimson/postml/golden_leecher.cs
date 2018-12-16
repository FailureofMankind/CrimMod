using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.NPCs.crimson.postml
{
	// This ModNPC serves as an example of a complete AI example.
	public class golden_leecher : ModNPC
	{
		private Player player;
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Golden Leecher");
		}

		public override void SetDefaults()
		{
			npc.width = 38;
			npc.height = 76;
			npc.aiStyle = 5;
			aiType = 6;
			npc.noGravity = true;
			npc.noTileCollide = true;
			npc.damage = 180;
			npc.defense = 25;
			npc.knockBackResist = 0f;
			
			npc.lifeMax = 2300;
			npc.HitSound = SoundID.NPCHit8;
			npc.DeathSound = SoundID.NPCDeath5;
			//npc.alpha = 175;
			//npc.color = new Color(0, 80, 255, 100);
			npc.value = 25f; // npc default to being immune to the Confused debuff. Allowing confused could be a little more work depending on the AI. npc.confused is true while the npc is confused.
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			if(spawnInfo.player.ZoneCrimson && MyWorld.ultraHardmode == true)
			{
				return 0.3f;
			}			
			return 0f;
		}

		public override void OnHitPlayer(Player player, int target, bool crit)
		{
			player.AddBuff(BuffID.Ichor, (60 * 25), true);
		}

        public override void NPCLoot()
		{
			if (Main.rand.Next(2) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("demonic_blood"), Main.rand.Next(2, 10));
			}
		}
    }
}
