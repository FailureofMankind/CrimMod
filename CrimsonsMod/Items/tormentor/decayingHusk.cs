using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.tormentor
{
	public class decayingHusk : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Decaying Husk");
			Tooltip.SetDefault("'It was already dead...'\n5% increased damage reduction and decreased damage\nEvery 5 seconds you release a cursed ball");
		}
        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = 10000;
            item.rare = 1;
            item.defense = 4;
            item.expert = true;
            item.accessory = true;
        }
        int count = 0;
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.endurance += 0.09f;
            
            player.meleeDamage -= 0.05f;
            player.magicDamage -= 0.05f;;
            player.rangedDamage -= 0.05f;;
            player.thrownDamage -= 0.05f;;
            player.minionDamage -= 0.05f;;

            count++;
            if(count > 300)
            {
                int a = Projectile.NewProjectile(player.Center.X, player.Center.Y, Main.rand.Next(-3, 3), Main.rand.Next(5, 10), 95, 20, 0, Main.myPlayer); //Spawning a projectile                
				Main.projectile[a].magic = false;   
                count = 0;             
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