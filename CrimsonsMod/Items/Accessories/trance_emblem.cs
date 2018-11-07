using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Accessories
{
	public class trance_emblem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Trance Emblem");
			Tooltip.SetDefault("'You feel like you have achieved nirvana'\n20% increased damage reduction\nIncreased mana and life regen\nYou are too peaceful to do much harm");
		}
        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 28;
            item.value = 10000000;
            item.rare = 5;
            item.defense = 3;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.lifeRegen += 35;
			player.manaRegen = 50;
			player.manaRegenBonus = 50;
            player.endurance += 0.20f;

			player.thrownDamage *= 0.20f;
			player.meleeDamage *= 0.20f;
			player.magicDamage *= 0.20f;
			player.rangedDamage *= 0.20f;
			player.minionDamage *= 0.20f;

            
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