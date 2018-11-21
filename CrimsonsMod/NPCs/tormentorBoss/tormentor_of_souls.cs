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
		}

		public override void SetDefaults()
		{
			npc.width = 100;
			npc.height = 100;
            npc.scale = 1.4f;
			npc.damage = 30;
			npc.defense = 4;
			npc.lifeMax = 3500;
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
            npc.damage = (int)(npc.damage * 0.5f);
            npc.defense = (int)(npc.defense + (numPlayers / 5));
        }	

		public override void AI()
        {
            
            moveSets(); //fucking thrust that shit nibba

            Target(); //Maximus Pedophilius

            //Attack(); //get ye ass clapped

            DespawnHandler(); // boredom lmao
        }	


		private void Target()
        {
            player = Main.player[npc.target]; // This will get the player target.
        }	

        int timer0 = 0;
        int timer1 = 0;
        int timer2 = 0;
        int timer3 = 0;
        int attackMode = 0;
        int maxAttackMode = 1;
        int timerMax = 300;
        private void moveSets()
        {
            //timer section
            timer0++;
            if(timer0 >= timerMax)
            {
                attackMode++;
                timer0 = 0;
            }
            if(attackMode > maxAttackMode)
            {
                attackMode = 0;
            }
            if(npc.life < npc.lifeMax * 0.7 && npc.life > npc.lifeMax * 0.4)
            {
                timerMax = 180;
            }
            if(npc.life < npc.lifeMax * 0.4 && Main.expertMode)
            {
                maxAttackMode = 2;
            }
            //timer section

            //attack mode: fly above player
            if(attackMode == 0)
            {
                moveThyArse();

                timer1++;
                if(timer1 >= 60)
                {
                    shootBall();
                    timer1 = 0;
                }
            }

            //attack mode: dash and spray
            if(attackMode == 1)
            {
                timer2++;
                if(timer2 >= 70 && npc.life > npc.lifeMax * 0.4)
                {
                    dashyB0i();
                    timer2 = 0;
                }
                if(timer2 >= 50 && npc.life <= npc.lifeMax * 0.4)
                {
                    dashyB0i();
                    timer2 = 0;
                }

                npc.velocity.Y *= 0.95f;
            }

            //attack mode: swave yes
            if(attackMode == 2)
            {
                hivemindCloneLmao();
                timer3++;
                if(timer3 >= 5)
                {
                    int lol = Projectile.NewProjectile(npc.Center.X, npc.Center.Y, Main.rand.Next(-10, 10), -5, mod.ProjectileType("tormentorShenaniganBall"), 7, 5, player.whoAmI, 0f, 0f);
                    Main.projectile[lol].timeLeft = 480;
                    timer3 = 0;
                }
            }
        }

        private void shootBall()
        {
            Vector2 velocityShoot = player.Center - npc.Center;
            float magnitude = Magnitude(velocityShoot);
            if(magnitude > 0)
            {
                velocityShoot *= 10f / magnitude;
            } 
            else
            {
                velocityShoot = new Vector2(0f, 10f);
            }            
            Projectile.NewProjectile(npc.Center.X, npc.Center.Y, velocityShoot.X, velocityShoot.Y, mod.ProjectileType("tormentorShenaniganBall"), 12, 5, player.whoAmI, 0f, 0f);
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
        private void dashyB0i()
        {
            player = Main.player[npc.target];

            Vector2 velocityShoot = player.Center - npc.Center;
            float magnitude = Magnitude(velocityShoot);
            if(magnitude > 0)
            {
                velocityShoot *= 30f / magnitude;
            } 
            else
            {
                velocityShoot = new Vector2(0f, 30f);
            }            
            npc.velocity = velocityShoot;

            float numberProjectiles = 5; // This defines how many projectiles to shot
            Vector2 p0sition = npc.position;
            float rotation = MathHelper.ToRadians(60);
            p0sition += Vector2.Normalize(velocityShoot) * 45f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = velocityShoot.RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .4f; // This defines the projectile roatation and speed. .4f == projectile speed
                Projectile.NewProjectile(p0sition.X, p0sition.Y, perturbedSpeed.X, perturbedSpeed.Y, mod.ProjectileType("tormentorShenaniganBall"), 10, 5, player.whoAmI);

            }
        }
        private void hivemindCloneLmao()
        {
            player = Main.player[npc.target];

            npc.ai[1] += 5f;
            double degWaveyBoi = (double) npc.ai[1]; 
            double radWaveyBoi = degWaveyBoi * (Math.PI / 180);

            npc.position.X = player.Center.X + (int)(Math.Cos(radWaveyBoi * 0.8) * 500);

            npc.position.Y = player.Center.Y - 250f;
           

           
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

		private void Attack()
        {
            


        }

        private float Magnitude(Vector2 mag)
        {
            return (float)Math.Sqrt(mag.X * mag.X + mag.Y * mag.Y);
        }



        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
	
	
	
	}
}
