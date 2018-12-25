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
//using CrimsonsMod.Items;
//using CrimsonsMod.NPCs;

namespace CrimsonsMod
{
    public class CrimsonPlayer : ModPlayer
    {
        public bool tideStrider = false;
        public bool nettlevineArmor = false;

        public override void ResetEffects()
        {
            tideStrider = false;
            nettlevineArmor = false;
        }

        public override void OnHitNPC(Item no, NPC target, int damage, float knockback, bool crit)
        {
            if(nettlevineArmor && Main.rand.Next(4) == 1)
            {
                target.AddBuff(BuffID.Venom, 240);
            }
        }

        public override void OnHitNPCWithProj(Projectile projectile, NPC target, int damage, float knockback, bool crit)
		{
            if(nettlevineArmor && Main.rand.Next(4) == 1)
            {
                
            }
        }

        public override void PostHurt(bool pvp, bool quiet, double damage, int hitDirection, bool crit)
        {
            if(tideStrider)
            {
                player.AddBuff(mod.BuffType("aquaticRush"), (60 * 5), true);
            }
        }

        public override void SetupStartInventory(IList<Item> startItem)
        {            

        }

        public override void UpdateBadLifeRegen()
        {

        }


        //chunks of useful shit, also thancc lynx
        private float Magnitude(Vector2 mag)
        {
            return (float)Math.Sqrt(mag.X * mag.X + mag.Y * mag.Y);
        }
    }
}