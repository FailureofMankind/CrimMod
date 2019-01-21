using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.NPCs.nettlevine
{
	public class nettleBee : ModNPC
	{
		private Player player;
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nettle Vine");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Hornet];
		}
		public override void SetDefaults()
		{
			npc.width = 40;
			npc.height = 40;
			npc.aiStyle = 5;
			animationType = 42;
			aiType = 42;
			npc.damage = 10;
			npc.defense = 9;
			npc.knockBackResist = 0.9f;
			npc.noTileCollide = false;
			npc.noGravity = true;
			npc.lifeMax = 15;
			npc.HitSound = SoundID.NPCHit25;
			npc.DeathSound = SoundID.NPCDeath8;
			npc.value = 50f;
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
			if(countShoot >= 60)
			{
				Main.PlaySound(SoundID.Item42, npc.position);
				Projectile.NewProjectile(npc.Center.X, npc.Center.Y, velocityShoot.X, velocityShoot.Y, 55, 15, 3, player.whoAmI, 0f, 0f);
				countShoot = 0;
			}
			
            Lighting.AddLight(npc.position, 0f, 0.5f, 0.1f);            
		}
		public override void OnHitPlayer(Player player, int target, bool crit)
		{
            if(Main.rand.Next(4) == 1)
			player.AddBuff(BuffID.Poisoned, Main.rand.Next(5, 60), true);
		}
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			if(spawnInfo.player.ZoneJungle && CrimsonsWorld.evilBossJungleActivation)
			{
				return 0.1f;
			}			
			return 0f;
		}
        public override void NPCLoot()
		{
			if (Main.rand.Next(1) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("poisonVine"), Main.rand.Next(8, 15));
			}
			if (Main.rand.Next(2) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Stinger, Main.rand.Next(2, 3));
			}
		}
	}
}
