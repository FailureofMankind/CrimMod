using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.NPCs.supplemements
{
	// This ModNPC serves as an example of a complete AI example.
	public class little_bubble : ModNPC
	{
		private Player player;
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mini Bubble");
		}

		public override void SetDefaults()
		{
			npc.width = 18;
			npc.height = 18;
			npc.aiStyle = 2; // This npc has a completely unique AI, so we set this to -1.
			npc.damage = 2;
			npc.defense = 0;
			npc.knockBackResist = 0.9f;
			npc.noTileCollide = true;
			npc.noGravity = true;
			npc.lifeMax = 45;
			npc.HitSound = SoundID.NPCHit5;
			npc.DeathSound = SoundID.NPCDeath7;
			//npc.alpha = 175;
			//npc.color = new Color(0, 80, 255, 100);
			npc.value = 0.5f; // npc default to being immune to the Confused debuff. Allowing confused could be a little more work depending on the AI. npc.confused is true while the npc is confused.
		}

        public override void AI()
        {
            int c = Dust.NewDust(npc.position, npc.width, npc.height, 87);
            Main.dust[c].scale = 1.2f;
        }

		public override void OnHitPlayer(Player player, int target, bool crit)
		{
            if(Main.rand.Next(3) == 1)
			player.AddBuff(BuffID.Confused, (60 * 10), true);
		}
	}
}
