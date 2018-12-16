using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.NPCs.tide
{
	public class waterTiger : ModNPC
	{
		private Player player;
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Water Tiger");
            Main.npcFrameCount[npc.type] = 6;
		}

		public override void SetDefaults()
		{
			npc.width = 44;
			npc.height = 26;
			npc.aiStyle = 16;
			animationType = 58;
			aiType = 58;
			npc.damage = 15;
			npc.defense = 13;
			npc.knockBackResist = 0.3f;
			npc.noTileCollide = false;
			npc.noGravity = true;
			npc.lifeMax = 35;
			npc.HitSound = SoundID.NPCHit25;
			npc.DeathSound = SoundID.NPCDeath8;
			npc.value = 50f;
		}

        public override void AI()
        {
			Lighting.AddLight(npc.position, 0f, 0.8f, 0.7f);
        }

		public override void OnHitPlayer(Player player, int target, bool crit)
		{
            if(Main.rand.Next(15) == 1)
			player.AddBuff(BuffID.Confused, (60 * 2), true);
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			NPC npc = this.npc;
			Player player = Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)];
			int tileX = (int)(player.Center.X / 16f);
			int tileY = (int)(player.Center.Y / 16f);
			bool inSky = (double)tileY < Main.worldSurface * (Main.hardMode? 0.44999998807907104 : 0.34999999403953552);

			if((tileX < 300 || tileX > Main.maxTilesX - 300) && tileY < Main.rockLayer && !inSky)
			{
				return 0.04f;
			}			
			return 0f;
		}
        public override void NPCLoot()
		{
			if (Main.rand.Next(1) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("tideScale"), Main.rand.Next(2, 8));
			}
		}
	}
}
