using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.NPCs.tide
{
	public class scaleySlime : ModNPC
	{
		private Player player;
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Scale Slime");
		}

		public override void SetDefaults()
		{
			npc.width = 30;
			npc.height = 30;
			npc.aiStyle = NPCID.BlueSlime;
			animationType = NPCID.BlueSlime;
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.BlueSlime];
			aiType = NPCID.BlueSlime; //kek
			npc.damage = 9;
			npc.defense = 2;            
			npc.knockBackResist = 1.4f;
			npc.lifeMax = 30;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 50f;
		}

        public override void AI()
        {
			Lighting.AddLight(npc.position, 0f, 0.5f, 0.7f);
        }

		public override void OnHitPlayer(Player player, int target, bool crit)
		{
            if(Main.rand.Next(9) == 1)
			player.AddBuff(BuffID.Confused, (60 * 2), true);
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldDaySlime.Chance * 0.2f;
		}
        public override void NPCLoot()
		{
			if (Main.rand.Next(1) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("tideScale"), Main.rand.Next(1, 2));
			}
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Gel, Main.rand.Next(1, 5));
		}
	}
}
