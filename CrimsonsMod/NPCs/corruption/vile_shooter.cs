using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.NPCs.corruption
{
	// This ModNPC serves as an example of a complete AI example.
	public class vile_shooter : ModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Flutter Slime"); // Automatic from .lang files
			DisplayName.SetDefault("Vile Spitter");
		}

		public override void SetDefaults()
		{
			npc.width = 44;
			npc.height = 40;
			animationType = 0;
			npc.aiStyle = 2;
			npc.damage = 8;
			npc.defense = 3;
			npc.lifeMax = 60;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 25f; // npc default to being immune to the Confused debuff. Allowing confused could be a little more work depending on the AI. npc.confused is true while the npc is confused.
		}

		int countShoot = 0;
		public override void AI()
		{
			Player player = Main.player[npc.target]; // This will get the player target.

            Vector2 velocityShoot = player.Center - npc.Center;
            float magnitude = (float)Math.Sqrt(velocityShoot.X * velocityShoot.X + velocityShoot.Y * velocityShoot.Y);
            if(magnitude > 0)
            {
                velocityShoot *= 10f / magnitude;
            } 
            else
            {
                velocityShoot = new Vector2(0f, 10f);
            }            
            
			countShoot++;
			if(countShoot >= 180)
			{
				Main.PlaySound(SoundID.Item42, npc.position);
				Projectile.NewProjectile(npc.Center.X, npc.Center.Y, velocityShoot.X, velocityShoot.Y, mod.ProjectileType("vile_shot"), 9, 3, player.whoAmI, 0f, 0f);
				countShoot = 0;
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			if(spawnInfo.player.ZoneCorrupt && !Main.hardMode)
			{
				return 0.3f;
			}			
			return 0f;
		}


	}
}
