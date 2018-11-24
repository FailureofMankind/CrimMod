using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Accessories.soulsType
{
	public class Soul_of_justice : ModItem
	{
        public float damageJustice = 5;

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Soul of Justice");
			Tooltip.SetDefault("'the concept and the resposability of respecting and applying the most objective law and simply does what is right!'\nProjectiles surround you, enacting according to your rights!\nDamage increases as you progress");
		}
        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = 0;
            item.rare = 1;
            item.accessory = true;
        }


        int timeSet = 0;
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            if(MyWorld.firstBoss)
            {
                damageJustice = 15;
            }
            if(NPC.downedBoss2)
            {
                damageJustice = 25;
            }
            if(Main.hardMode)
            {
                damageJustice = 50;
            }
            if(NPC.downedMechBossAny)
            {
                damageJustice = 75;
            }
            if(NPC.downedPlantBoss)
            {
                damageJustice = 100;
            }
            if(NPC.downedGolemBoss)
            {
                damageJustice = 125;
            }
            if(NPC.downedAncientCultist)
            {
                damageJustice = 175;
            }
            if(NPC.downedMoonlord)
            {
                damageJustice = 300;
            }
            timeSet++;
            if(timeSet >= 300 && !NPC.downedMoonlord)
            {
                Projectile.NewProjectile(Main.player[item.owner].Center.X, Main.player[item.owner].Center.Y, 0, 0, mod.ProjectileType("soul_of_justiceProj"), 25, 2f, Main.myPlayer, 0f, 0f);
                timeSet = 0;
            }
            if(timeSet >= 180 && NPC.downedMoonlord)
            {
                Projectile.NewProjectile(Main.player[item.owner].Center.X, Main.player[item.owner].Center.Y, 0, 0, mod.ProjectileType("soul_of_justiceProj"), 25, 2f, Main.myPlayer, 0f, 0f);
                timeSet = 0;
            }
        
        }
    }
}
/*
            player.noFallDmg = true; 
            player.canRocket = true;
            player.rocketTime = 1200;
            player.rocketBoots = 1;
            player.rocketTimeMax = 1200;
            player.aggro += 300;
            player.meleeCrit += 17;
            player.meleeDamage += 0.22f;
            player.meleeSpeed += 0.15f;
            player.moveSpeed += 2.15f;
            player.rangedCrit += 7;
            player.rangedDamage += 0.16f;
            player.maxMinions++;
            player.minionDamage += 0.22f;
            player.statManaMax2 += 60;
            player.manaCost -= 0.15f;
            player.magicCrit += 7;
            player.magicDamage += 1.07f;
*/