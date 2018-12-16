using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.GameContent;
using Terraria.GameContent.UI;
using Terraria.GameInput;
using Terraria.Graphics.Capture;
using Terraria.Graphics.Effects;
using Terraria.Localization;
using Terraria.Graphics.Shaders;
using CrimsonsMod.Items;
using CrimsonsMod.NPCs;

namespace CrimsonsMod
{
    public class CrimsonPlayer : ModPlayer
    {
        //armor set bonuses
        public bool ferrium = false;
        public bool barkwoodSet = false;
        public bool moltenVisor = false;
        public bool geodeThrowing = false;
        public bool geodeMagic = false;
        public bool geodeMelee = false;
        public bool geodeRanged = false;

        //accessories
        public bool forestPendantEffect = false;
        public bool iceCoreShield = false;
        public bool soulOfJusticeQuirk = false;
        public bool soulOfIntegrityQuirk = false;

        //buffs


        //debuffs



        public override void ResetEffects()
        {
            //armor
            ferrium = false;
            barkwoodSet = false;
            moltenVisor = false;
            geodeThrowing = false;
            geodeMagic = false;
            geodeMelee = false;
            geodeRanged = false;

            //accessories
            forestPendantEffect = false;
            soulOfJusticeQuirk = false;
            soulOfIntegrityQuirk = false;
            iceCoreShield = false;

            //debuffs
        }

        public override void OnHitNPC(Item no, NPC target, int damage, float knockback, bool crit)
        {
            if(ferrium)
            {
                int a = Projectile.NewProjectile(target.Center.X, target.Center.Y, 0, 0, 296, (int)(damage * 0.7), 0, Main.myPlayer); //Spawning a projectile
                Main.projectile[a].melee = true;
                Main.projectile[a].timeLeft = 30;
                Main.projectile[a].scale = 2f;
            }
            if(soulOfIntegrityQuirk)
            {
                int melee0 = Projectile.NewProjectile(target.Center.X, target.Center.Y, 0, -20, 93, damage, 0, Main.myPlayer);
                Main.projectile[melee0].magic = false;
            }
            
            //debuffs
            if(target.HasBuff(mod.BuffType("crystal_crush")) && target.life >= damage / 10)
            {
                target.life -= (int)damage / 10;
            }
        }

        int geodeThrowingHealCount = 0;
        public override void OnHitNPCWithProj(Projectile projectile, NPC target, int damage, float knockback, bool crit)
		{
            //armor
            if(moltenVisor && projectile.thrown == true)
            {
                target.AddBuff(24, 180); //onfire
            }
            if(geodeThrowing && projectile.thrown)
            {
                Player player = Main.player[projectile.owner];
                geodeThrowingHealCount++;
                if(geodeThrowingHealCount >= 5)
                {
                    player.statLife += 3;
                    player.HealEffect(3, true);                    
                
                    for (int i = 0; i<10; i++)
                    {            
                        int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 227);
                        Main.dust[dust].velocity *= 4f;
                        Main.dust[dust].scale = 2f;
                        Main.dust[dust].noGravity = true; 
                    }
                    geodeThrowingHealCount = 0;
                }
            }
            if(geodeMagic && projectile.magic)
            {
                Main.PlaySound(SoundID.Item43, projectile.position);        
                for (int i = 0; i < 2; i++)
                {            
                    int notMagicStars = Projectile.NewProjectile(target.Center.X, target.Center.Y - 600, Main.rand.Next(-5, 5), Main.rand.Next(30, 50), 92, (int)(damage * 0.1), 0, Main.myPlayer);
                    Main.projectile[notMagicStars].magic = false;
                    Main.projectile[notMagicStars].ranged = false;
                    Main.projectile[notMagicStars].penetrate = 1;
                }
            }
            if(geodeRanged && projectile.ranged && projectile.timeLeft > 180)
            {
                for(int i = 0; i < 1; i++)
                {
                    Vector2 positionProj1 = new Vector2(target.Center.X - 500, target.Center.Y + Main.rand.Next(-500, 500));
                    Vector2 velocityShoot = target.Center - positionProj1;
                    float magnitude = Magnitude(velocityShoot);
                    if(magnitude > 0)
                    {
                        velocityShoot *= 75f / magnitude;
                    } 
                    else
                    {
                        velocityShoot = new Vector2(0f, 10f);
                    }            
                    int FUCKINGSTORMHELL = Projectile.NewProjectile(positionProj1.X, positionProj1.Y, velocityShoot.X, velocityShoot.Y, projectile.type, (int)damage / 2, 5, player.whoAmI, 0f, 0f);
                    Main.projectile[FUCKINGSTORMHELL].ranged = false;
                    Main.projectile[FUCKINGSTORMHELL].tileCollide = false;
                    Main.projectile[FUCKINGSTORMHELL].timeLeft = 120;
                    Main.projectile[FUCKINGSTORMHELL].noDropItem = true;
                }
                for(int i = 0; i < 1; i++)
                {
                    Vector2 positionProj2 = new Vector2(target.Center.X + 500, target.Center.Y + Main.rand.Next(-500, 500));
                    Vector2 velocityShoot = target.Center - positionProj2;
                    float magnitude = Magnitude(velocityShoot);
                    if(magnitude > 0)
                    {
                        velocityShoot *= 75f / magnitude;
                    } 
                    else
                    {
                        velocityShoot = new Vector2(0f, 10f);
                    }            
                    int FUCKINGSTORMHELL = Projectile.NewProjectile(positionProj2.X, positionProj2.Y, velocityShoot.X, velocityShoot.Y, projectile.type, (int)damage / 2, 0, Main.myPlayer);
                    Main.projectile[FUCKINGSTORMHELL].ranged = false;
                    Main.projectile[FUCKINGSTORMHELL].tileCollide = false;
                    Main.projectile[FUCKINGSTORMHELL].timeLeft = 120;
                    Main.projectile[FUCKINGSTORMHELL].noDropItem = true;
                }
            }

            //accessories
            if (forestPendantEffect && projectile.minion)
            {
                target.AddBuff(20, 90); //poisoned
            }            
            if(soulOfIntegrityQuirk)
            {
                if(projectile.melee == true)
                {
                    int melee1 = Projectile.NewProjectile(target.Center.X, target.Center.Y, 0, -20, 93, (int)(damage * 0.5), 0, Main.myPlayer);
                    Main.projectile[melee1].magic = false;

                }
                if(projectile.ranged == true)
                {
                    int ranged1 = Projectile.NewProjectile(target.Center.X, target.Center.Y, projectile.velocity.X, projectile.velocity.X, 126, (int)(damage * 0.1), 0, Main.myPlayer);
                    Main.projectile[ranged1].magic = false;
                    Main.projectile[ranged1].timeLeft = 120;
                }
                if(projectile.magic == true)
                {
                    int magic1 = Projectile.NewProjectile(target.Center.X, target.Center.Y, 0, -10, mod.ProjectileType("soul_of_integrityProj"), (int)(damage * 0.5), 0, Main.myPlayer);
                    Main.projectile[magic1].timeLeft = 120;

                }
                if(projectile.minion == true)
                {
                    target.AddBuff(72, 120); //midas
                }
                if(projectile.thrown == true)
                {
                    target.AddBuff(20, 120); //poison
                }
            }

            //debuffs(npc)
            if(target.HasBuff(mod.BuffType("crystal_crush")) && target.life >= damage / 10)
            {
                target.life -= (int)damage / 10;
            }
        }

        public override void PostHurt(bool pvp, bool quiet, double damage, int hitDirection, bool crit)
        {
            if(iceCoreShield)
            {
                for(int i = 0; i < 10; i++)
                {
                    int crystalOof = Projectile.NewProjectile(player.Center.X, player.Center.Y, Main.rand.Next(-5, 5), Main.rand.Next(-5, 5), 90, 10, 2, Main.myPlayer);                
                    Main.projectile[crystalOof].ranged = false;
                    Main.projectile[crystalOof].melee = true;
                }
            }
            if(geodeMelee)
            {
                for(int i = 0; i < 4; i++)
                {
                    Projectile.NewProjectile(player.Center.X, player.Center.Y, Main.rand.Next(-5, 5), Main.rand.Next(-5, 5), mod.ProjectileType("crystal_armor_proj"), 30, 5, Main.myPlayer);                
                }
            }
        }

        public override void SetupStartInventory(IList<Item> startItem)
        {            
            Item item = new Item();
            item.SetDefaults(mod.ItemType("Soul_of_neutrality"));
            item.stack = 1;
            startItem.Add(item);
        }
        /*public override void UpdateBadLifeRegen()
        {
            if(septic_curse == true)
            {
                player.defense -= 5;
                
                player.meleeDamage *= 0.50f;
                player.rangedDamage *= 0.50f;
                player.magicDamage *= 0.50f;
                player.summonDamage *= 0.50f;
                player.thrownDamage *= 0.50f;
            }
            

        }*/


        //chunks of useful shit
        private float Magnitude(Vector2 mag)
        {
            return (float)Math.Sqrt(mag.X * mag.X + mag.Y * mag.Y);
        }
    }
}