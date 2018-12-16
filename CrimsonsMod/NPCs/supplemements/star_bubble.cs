using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.NPCs.supplemements
{
	// This ModNPC serves as an example of a complete AI example.
	public class star_bubble : ModNPC
	{
		private Player player;
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Star Bubble");
		}

		public override void SetDefaults()
		{
			npc.width = 48;
			npc.height = 48;
			npc.aiStyle = 85; // This npc has a completely unique AI, so we set this to -1.
			npc.damage = 25;
			npc.defense = 5;
			npc.knockBackResist = 0.5f;
			npc.noTileCollide = true;
			npc.noGravity = true;
			npc.lifeMax = 90;
			npc.HitSound = SoundID.NPCHit5;
			npc.DeathSound = SoundID.NPCDeath7;
			//npc.alpha = 175;
			//npc.color = new Color(0, 80, 255, 100);
			npc.value = 25f; // npc default to being immune to the Confused debuff. Allowing confused could be a little more work depending on the AI. npc.confused is true while the npc is confused.
		}

        public override void AI()
        {
            int c = Dust.NewDust(npc.position, npc.width, npc.height, 87);
            Main.dust[c].scale = 2f;
        }

		public override void OnHitPlayer(Player player, int target, bool crit)
		{
            if(Main.rand.Next(10) == 1)
			player.AddBuff(BuffID.Confused, (60 * 10), true);
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			if(spawnInfo.player.ZoneSkyHeight)
			{
				return 0.05f;
			}			
			return 0f;
		}
        public override void NPCLoot()
		{
			for(int i = 0; i < 5; i++)
			{
                NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, mod.NPCType("little_bubble"), 0, npc.whoAmI, 1f, 0f, 30f);
			}
			if (Main.rand.Next(2) == 1)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("star_shard"), Main.rand.Next(2, 7));
			}
		}
	}
}
