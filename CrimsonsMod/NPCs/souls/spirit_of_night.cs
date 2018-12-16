using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.NPCs.souls
{
	public class spirit_of_night : ModNPC
	{
		private Player player;	
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spirit of Night");
		}

		public override void SetDefaults()
		{
			npc.width = 30;
			npc.height = 30;
			animationType = 0;			
			npc.aiStyle = 2;
			npc.damage = 8;
			npc.defense = 3;
			npc.knockBackResist = 0f;
			npc.noGravity = true;
			npc.noTileCollide = true;
			npc.lifeMax = 450;
			npc.HitSound = SoundID.NPCHit5;
			npc.DeathSound = SoundID.NPCDeath46;
			npc.value = 25f;
        }
	
		public override void AI()
		{
            player = Main.player[npc.target];

            Vector2 velocityShoot = player.Center - npc.Center;
            float magnitude = (float)Math.Sqrt(velocityShoot.X * velocityShoot.X + velocityShoot.Y * velocityShoot.Y);
            if(magnitude > 0)
            {
                velocityShoot *= 5f / magnitude;
                npc.velocity = velocityShoot;
            }
			npc.rotation += 0.1f;
		}
	}
}
