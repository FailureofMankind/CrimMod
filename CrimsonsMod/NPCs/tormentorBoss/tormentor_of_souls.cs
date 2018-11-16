//thancc lynx :D

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

namespace CrimsonsMod.NPCs.tormentorBoss
{
	[AutoloadBossHead]
	public class tormentor_of_souls : ModNPC
	{
		private Player player;	


		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tormentor of Souls");
			Main.npcFrameCount[npc.type] = 10;
		}

		public override void SetDefaults()
		{
			npc.width = 100;
			npc.height = 100;
            npc.scale = 1.4f;
			npc.damage = 30;
			npc.defense = 4;
			npc.lifeMax = 5000;
			npc.HitSound = SoundID.NPCHit27;
			npc.DeathSound = SoundID.NPCDeath22;
			npc.boss = true;
            npc.npcSlots = 25;
			npc.knockBackResist = 0f;
			aiType = 0;
			music = 12;
			npc.noGravity = true;
			npc.aiStyle = 0;
			animationType = 35;
			npc.noTileCollide = true;
			//bossBag = mod.ItemType("seaturtleBag");			
		}
	
		public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.500f * bossLifeScale);
            npc.damage = (int)(npc.damage * 0.6f);
            npc.defense = (int)(npc.defense + (numPlayers / 5));
        }	

		public override void AI()
        {
            moveThyArse(); //fucking thrust that shit nibba

            Target(); //Maximus Pedophilius

            //Attack(); //get ye ass clapped

            DespawnHandler(); // boredom lmao
        }	


		private void Target()
        {
            player = Main.player[npc.target]; // This will get the player target.
        }	


        private void moveThyArse()
        {
            player = Main.player[npc.target]; // This will get the player target.

            float velociCap = 5;

            if(npc.Center.X + 10 > player.Center.X)
            {
                npc.velocity.X += -0.5f;
            }

            if(npc.Center.X -10 < player.Center.X)
            {
                npc.velocity.X += 0.5f;
            }
            
            if(npc.Center.Y + 300 > player.Center.Y)
            {
                npc.velocity.Y += -0.3f;
            }
        
            if(npc.Center.Y + 300  < player.Center.Y)
            {
                npc.velocity.Y += 0.3f;
            }

            
            if(npc.velocity.Y > velociCap)
            {
                npc.velocity.Y = velociCap;
            }
            if(npc.velocity.Y < velociCap * -1)
            {
                npc.velocity.Y = velociCap * -1;
            }
            if(npc.velocity.X > velociCap)
            {
                npc.velocity.X = velociCap;
            }
            if(npc.velocity.X < velociCap * -1)
            {
                npc.velocity.X = velociCap * -1;
            }
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



        }





        private void DiscountSlimeGod()
        {
            npc.aiStyle = 1;
            aiType = 1;
            npc.noTileCollide = false;
            npc.noGravity = false;
            
                        
            if(Main.rand.Next(200) == 0)
            {
                if(npc.position.X > player.position.X)
                {
                    npc.velocity.X += -5;
                }
                if(npc.position.X < player.position.X)
                {
                    npc.velocity.X += 5;
                }
            }
            
            
            
            
            if(Main.rand.Next(20) == 0 && npc.npcSlots < 100)
            {
                NPC.NewNPC((int)(npc.position.X - 100), (int)(npc.position.Y - 100), mod.NPCType("aerossault_slime_minion"), 0, npc.whoAmI, 1f, 0f, 30f);
            }
            
            Dust.NewDustDirect(npc.position, npc.width, npc.height, 91);       
        }

        
        
        private void TorpedoReeeeeeeeee()
        {
            npc.aiStyle = -1;
            npc.noTileCollide = true;
            npc.noGravity = true;


            if(npc.position.X + 00 > player.position.X)
            {
                npc.velocity.X += -2;
            }

            if(npc.position.X + 00  < player.position.X)
            {
                npc.velocity.X += 2;
            }
            
            if(npc.position.Y + 500 > player.position.Y)
            {
                npc.velocity.Y += -0.04f;
            }
        
            if(npc.position.Y + 500  < player.position.Y)
            {
                npc.velocity.Y += 0.04f;
            }
        
                Dust.NewDustDirect(npc.position, npc.width, npc.height, 91);     
            
            double count = 0;
            double shootProj = count % 100;
            count += 1f;
            
            if(shootProj == 0)
            {
            Projectile.NewProjectile(npc.position.X, npc.position.Y, (int)(Main.rand.Next(-3, 3)), 5, mod.ProjectileType("aerossault_beam"), 20, 3f, Main.myPlayer, npc.whoAmI);        

            }

        }

        
        
        
        private void CamperBulletHell()
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
