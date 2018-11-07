using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CrimsonsMod.NPCs
{

	[AutoloadBossHead]
	public class sea_turtle : ModNPC
	{
		private Player player;		


		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sea Turtle");
			Main.npcFrameCount[npc.type] = 8;
		}

		public override void SetDefaults()
		{
		    npc.scale = 1.2f;
			npc.width = 80;
			npc.height = 80;
			npc.damage =20;
			npc.defense = 5;
			npc.lifeMax = 2100;
			npc.HitSound = SoundID.NPCHit25;
			npc.DeathSound = SoundID.NPCDeath28;
			npc.boss = true;
			npc.knockBackResist = 0f;
			aiType = 63;
			music = 41;
			npc.noGravity = true;
			npc.aiStyle = 63;
			animationType = 472;
			npc.noTileCollide = true;
		}
	
		public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.500f * bossLifeScale);
            npc.damage = (int)(npc.damage * 0.9f);
            npc.defense = (int)(npc.defense + numPlayers);
        }	

		public override void AI()
        {
            Target(); // Sets the Player Target

            Attack(); //attack ai of the slime

            DespawnHandler(); // Handles if the NPC should despawn.
        }	

		private void Target()
        {
            player = Main.player[npc.target]; // This will get the player target.
        }	

        public override bool? DrawHealthBar(byte hbPosition, ref float scale, ref Vector2 position)
        {
            scale = 1.5f;
            return null;
        }

		private void DespawnHandler()
        {
            if(!player.active || player.dead || Main.dayTime)
            {
                npc.TargetClosest(false);
                player = Main.player[npc.target];
                if(!player.active || player.dead)
                {
                    npc.velocity = new Vector2(0f, -50f);
                    if(npc.timeLeft > 10)
                    {
                        npc.timeLeft = 10;
                    }
                    return;
                }
            }
        }				

		private void Attack()  //set of moves the boss will do
        {
            int phase = 0; //the type of attack
            
            
        
            if(phase == 0)
            {
                NimbusBoi();
            }
        
            if(phase == 1)
            {
                TurtleSpin();
            }

            if(phase == 2)
            {
                MimicSlam();
            }
			
			if(phase == 3)
            {
                OriginalDash();
            }

            /*if(phase > 2)
            {
                phase = 0;
            }*/
        }

        private void NimbusBoi()
        {
            npc.aiStyle = 63;
            aiType = 63;
            npc.noTileCollide = true;
            npc.noGravity = true;
 
            if(Main.rand.Next(20) == 0 && npc.npcSlots < 100)
            {
                Projectile.NewProjectile(npc.position.X, npc.position.Y, (int)(Main.rand.Next(0, 0)), (int)(Main.rand.Next(0, 0)), mod.ProjectileType("sea_turtle_trail"), npc.damage, 3f, Main.myPlayer, npc.whoAmI);
            }     
        }

        
        
        private void TurtleSpin()
        {
            npc.aiStyle = 39;
            npc.noTileCollide = true;
            npc.noGravity = false;       
        }

        private void MimicSlam()
        {
            npc.aiStyle = -1;
            npc.noTileCollide = true;
            npc.noGravity = true;          
        }
		
		private void OriginalDash()
        {
            npc.aiStyle = -1;
            npc.noTileCollide = true;
            npc.noGravity = true;


            npc.velocity.X /= 2f;
            npc.velocity.Y /= 2f;
        
            for (int i = 0; i<5; i++)
            {            
                Dust.NewDustDirect(npc.position, npc.width, npc.height, 91);     
            }


            Projectile.NewProjectile(npc.position.X, npc.position.Y, (int)(Main.rand.Next(-10, 10)), (int)(Main.rand.Next(-10, 10)), mod.ProjectileType("aerossault_beam"), npc.damage, 3f, Main.myPlayer, npc.whoAmI);        
        
        }
	}
}
