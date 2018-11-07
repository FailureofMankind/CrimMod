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


namespace CrimsonsMod
{



    public class CrimsonPlayer : ModPlayer
    {
        public bool ferrium = false;
        
        //debuffs
        public bool septic_curse = false;


        public override void ResetEffects()
        {
            ferrium = false;
            septic_curse = false;
        }
        public override void UpdateDead()
        {
            septic_curse = false;
        }

        public override void OnHitNPC(Item no, NPC target, int damage, float knockback, bool crit)
        {
            if(ferrium)
            {
                Projectile.NewProjectile(target.Center.X, target.Center.Y, 0, 0, 296, damage, 0, Main.myPlayer); //Spawning a projectile
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