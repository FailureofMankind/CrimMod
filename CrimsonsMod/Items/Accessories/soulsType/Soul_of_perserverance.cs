using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Accessories.soulsType
{
	public class Soul_of_perserverance : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Soul of Perserverance");
			Tooltip.SetDefault("'the ability to stand your ground against indomitable odds'\nImmunity to cursed and confusion debuffs");
		}
        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = 0;
            item.rare = 1;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.buffImmune[23] = true; //cursed debuff
            player.buffImmune[31] = true; //confusion debuff

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