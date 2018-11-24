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
using Terraria.Graphics.Shaders;
using CrimsonsMod.Items;
using CrimsonsMod.NPCs;


namespace CrimsonsMod
{



    public class CrimsonPlayer : ModPlayer
    {
        //armor set bonuses
        public bool ferrium = false;

        //accessories
        public bool forestPendantEffect = false;
        public bool soulOfJusticeQuirk = false;
        public bool soulOfIntegrityQuirk = false;

        //buffs


        //debuffs


        //misseccieliuosudcvdofbksdjn

        public override void ResetEffects()
        {
            ferrium = false;
            forestPendantEffect = false;
            soulOfJusticeQuirk = false;
            soulOfIntegrityQuirk = false;
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

        
        }

        public override void OnHitNPCWithProj(Projectile projectile, NPC target, int damage, float knockback, bool crit)
		{
            if (forestPendantEffect && projectile.minion)
            {
                target.AddBuff(20, 120); //poisoned
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




    }
}