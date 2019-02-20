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
        public int projectileDamage = 0;
        public float movementFacter = 0; //xd
        public float velociCap = 0;
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tormentor of Souls");
            Main.npcFrameCount[npc.type] = 10;
		}

		public override void SetDefaults()
		{
			npc.width = 150;
			npc.height = 150;
			npc.damage = 20;
            projectileDamage = 7;
            movementFacter = 30f;
			npc.defense = 4;
			npc.lifeMax = 4200;
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
			bossBag = mod.ItemType("tormentorBag");			
		}
		private void Target()
        {
            Player player = Main.player[npc.target]; // This will get the player target.
        }        
		public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.500f * bossLifeScale);
            npc.damage = (int)(npc.damage * 0.5f);
            npc.defense = (int)(npc.defense + (numPlayers / 5));
        }	

		public override void AI()
        {   
            moveSets(); //fucking thrust that shit nibbas

            enrageModer();//begone THOT

            Target(); //Maximus Pedophilius

            DespawnHandler(); // boredom lmao
        }	

        bool coolMode = false; //when this true, shenanigans happen yes
        bool coolModeDone = false;
        int shenaniganModeTimer = 0;
        int touhouTimer = 0;

        int timer0 = 0; //because y not
        int timer1 = 0;
        int timer2 = 0;
        int timer3 = 0;
        int attackMode = 0;
        int maxAttackMode = 1;
        int timerMax = 420;
        private void moveSets()
        {
            if(!coolMode)
            {
                npc.dontTakeDamage = false;
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
                    timerMax = 210;
                }
                if(npc.life < npc.lifeMax * 0.4 && Main.expertMode)
                {
                    maxAttackMode = 2;
                    if (!coolModeDone)
                    {
                        coolMode = true;
                    }
                }

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
                        int lol = Projectile.NewProjectile(npc.Center.X, npc.Center.Y, Main.rand.Next(-10, 10), -5, mod.ProjectileType("tormentorShenaniganBall"), projectileDamage, 5, player.whoAmI, 0f, 0f);
                        Main.projectile[lol].timeLeft = 480;
                        timer3 = 0;
                    }
                }
            }
            else
            {
                npc.dontTakeDamage = true;
                
                shenaniganModeTimer++;
                if(shenaniganModeTimer > 60*20)
                {
                    coolModeDone = true;
                    coolMode = false;
                }

                //ok now touhou phase hahayes
                touhouTimer++;
                if(touhouTimer < 60*10 && touhouTimer > 60*2) //brake
                {
                    npc.velocity *= 0.9f;
                }
                if(touhouTimer < 60*10 && touhouTimer > 60*2) //phase 1 uwu
                {
                    npc.localAI[0]++;
                    //x is sine, y is cosine and have same function quik mafs
                    float xVar = (float)Math.Sin(npc.localAI[0] * 0.85)*10;
                    float yVar = (float)Math.Cos(npc.localAI[0] * 0.85)*10;
                    Projectile.NewProjectile(npc.Center.X, npc.Center.Y, xVar, yVar, mod.ProjectileType("shenaniganTouhouBullet"), projectileDamage, 5, player.whoAmI, 0f, 0f);
                }
                if(touhouTimer < 60*20 && touhouTimer > 60*10) //phase 2 owo
                {
                    Vector2 moveVel = new Vector2(player.Center.X - npc.Center.X, (player.Center.Y - 500) - npc.Center.Y);
                    float magnitude = Magnitude(moveVel);
                    if(magnitude > 20)
                    {
                        moveVel *= 10f / magnitude;
                    } 
                    else
                    {
                        moveVel *= 0.5f;
                    }          
                    npc.velocity = moveVel;

                    npc.localAI[1]++;
                    if(npc.localAI[1] % 60 == 0)
                    {
                        Projectile.NewProjectile(npc.Center.X, npc.Center.Y, 10, 0, mod.ProjectileType("horizontalRainBullet"), projectileDamage, 5, player.whoAmI, 0f, 0f);
                        Projectile.NewProjectile(npc.Center.X, npc.Center.Y, -10, 0, mod.ProjectileType("horizontalRainBullet"), projectileDamage, 5, player.whoAmI, 0f, 0f);
                        
                        Projectile.NewProjectile(npc.Center.X, npc.Center.Y, -5, 5, mod.ProjectileType("shenaniganTouhouBullet"), projectileDamage, 5, player.whoAmI, 0f, 0f);
                        Projectile.NewProjectile(npc.Center.X, npc.Center.Y, 0, 7, mod.ProjectileType("shenaniganTouhouBullet"), projectileDamage, 5, player.whoAmI, 0f, 0f);
                        Projectile.NewProjectile(npc.Center.X, npc.Center.Y, 5, 5, mod.ProjectileType("shenaniganTouhouBullet"), projectileDamage, 5, player.whoAmI, 0f, 0f);
                    }
                }
            }
        }

        private void shootBall()
        {
            Vector2 velocityShoot = player.Center - npc.Center;
            float magnitude = Magnitude(velocityShoot);
            if(magnitude > 0)
            {
                velocityShoot *= (movementFacter / magnitude)/2;
            } 
            else
            {
                velocityShoot = new Vector2(0f, 10f);
            }            
            Projectile.NewProjectile(npc.Center.X, npc.Center.Y, velocityShoot.X, velocityShoot.Y, mod.ProjectileType("tormentorShenaniganBall"), (int)projectileDamage, 5, player.whoAmI, 0f, 0f);
        }

        private void moveThyArse()
        {
            player = Main.player[npc.target]; // This will get the player target.*/

            if(npc.Center.X + 10 > player.Center.X)
            {
                npc.velocity.X += -0.4f;
            }

            if(npc.Center.X -10 < player.Center.X)
            {
                npc.velocity.X += 0.4f;
            }
            
            if(npc.Center.Y + 300 > player.Center.Y)
            {
                npc.velocity.Y += -0.3f;
            }
        
            if(npc.Center.Y + 300 < player.Center.Y)
            {
                npc.velocity.Y += 0.3f;
            }
            if(Math.Abs(npc.Center.Y - player.Center.Y + 300) > 0 && Math.Abs(npc.Center.Y - player.Center.Y + 300) < 30)
            {
                npc.velocity.Y *= 0.3f;
            }
            
            if(npc.velocity.Y > movementFacter)
            {
                npc.velocity.Y = movementFacter;
            }
            if(npc.velocity.Y < movementFacter * -1)
            {
                npc.velocity.Y = movementFacter * -1;
            }
            if(npc.velocity.X > movementFacter)
            {
                npc.velocity.X = movementFacter;
            }
            if(npc.velocity.X < movementFacter * -1)
            {
                npc.velocity.X = movementFacter * -1;
            }

        }
        private void dashyB0i()
        {
            player = Main.player[npc.target];
            Vector2 velocityShoot = player.Center - npc.Center;
            float magnitude = Magnitude(velocityShoot);
            if(magnitude > 0)
            {
                velocityShoot *= movementFacter / magnitude;
            } 
            else
            {
                velocityShoot = new Vector2(0f, 30f);
            }            
            npc.velocity = velocityShoot;
            npc.velocity.Y *= 0.8f;

            float numberProjectiles = 5; // This defines how many projectiles to shoot
            Vector2 p0sition = npc.position;
            float rotation = MathHelper.ToRadians(40);
            p0sition += Vector2.Normalize(velocityShoot) * 45f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = velocityShoot.RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .4f; // This defines the projectile roatation and speed. .4f == projectile speed
                Projectile.NewProjectile(p0sition.X, p0sition.Y, perturbedSpeed.X, perturbedSpeed.Y, mod.ProjectileType("tormentorShenaniganBall"), projectileDamage, 5, player.whoAmI);
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
        private float Magnitude(Vector2 mag)
        {
            return (float)Math.Sqrt(mag.X * mag.X + mag.Y * mag.Y);
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
                    npc.velocity = new Vector2(0f, 50f);
                    if(npc.timeLeft > 10)
                    {
                        npc.timeLeft = 10;
                    }
                    return;
                }
            }
        }
        bool roarFlag = false;
        private void enrageModer()
        {
            if(!player.ZoneCorrupt)
            {
                npc.defense = 9999;
                projectileDamage = 30;
                movementFacter = 75f;
                npc.damage = 60;
                if(!roarFlag)
                {
        			Main.PlaySound(SoundID.Roar, npc.position, 0);
                    roarFlag = true;
                }
            }
            else
            {
                projectileDamage = 7;
                movementFacter = 20f;
                npc.defense = 4;
                npc.damage = 20;
                roarFlag = false;
            }           
        }	
        public override void NPCLoot()
		{
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("tormentorBag"));
		}
        public override void FindFrame(int frameHeight)
		{
			npc.frameCounter++;
			if (npc.frameCounter >= 10)
			{
				npc.frame.Y = (npc.frame.Y / frameHeight + 1) % Main.npcFrameCount[npc.type] * frameHeight;
				npc.frameCounter = 0;
			}

			npc.spriteDirection = 0;

			if (npc.rotation != 0)
			{
				npc.rotation = 0;
			}
		}
	}
}
