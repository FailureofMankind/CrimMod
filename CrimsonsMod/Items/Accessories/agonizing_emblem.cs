using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Accessories
{
	public class agonizing_emblem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Agonizing Emblem");
			Tooltip.SetDefault("'It hurts.. It hurts so much.....'\nIncreases damage by 150% but you take massive damage.\nMana regen is disabled\nYou lose life until you are left with 40 health");
		}
        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 28;
            item.value = 10000000;
            item.rare = 6;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.lifeRegen = -75;
            if(player.statLife <= 100)
            {
                player.lifeRegen = -35;
                
                if(player.statLife <= 40)
                {
                    player.lifeRegen = 0;
                }

            }


			player.manaRegen = -15;
			player.manaRegenBonus = -50;
            player.endurance -= 1000f;

			player.thrownDamage *= 2.50f;
			player.meleeDamage *= 2.50f;
			player.magicDamage *= 2.50f;
			player.rangedDamage *= 2.50f;
			player.minionDamage *= 2.50f;

            
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