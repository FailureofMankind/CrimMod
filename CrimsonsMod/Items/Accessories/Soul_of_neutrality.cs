using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Accessories
{
	public class Soul_of_neutrality : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Soul of Neutrality");
			Tooltip.SetDefault("'state where the human no longer possesses concern over anything at all. Nothing matters'\nAre you sure you want to delete your soul?");
		}
        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = 0;
            item.rare = -1;
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