using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.aluminum
{
	[AutoloadEquip(EquipType.Head)]
	public class aluminum_helmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Aluminum Helmet");
			Tooltip.SetDefault("2% increased damage");
            
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 28;
			item.value = 10000;
			item.rare = 1;
			item.defense = 3;
		}

		public override void UpdateEquip(Player player)
		{
			player.meleeDamage += 0.02f;
			player.magicDamage += 0.02f;
			player.rangedDamage += 0.02f;
			player.thrownDamage += 0.02f;
			player.minionDamage += 0.02f;
		}
		
        
        public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("aluminum_armor") && legs.type == mod.ItemType("aluminum_legging");
		}
    

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "You are very heavy and fall faster\nDamage decreases as health decreases";
			
			float damageMultiplier = 1;
			if(player.statLife <= (player.statLifeMax * 0.1) )
			{
				damageMultiplier = 0.5f;
			}
			if(player.statLife > (player.statLifeMax * 0.1) && player.statLife <= (player.statLifeMax * 0.3) )
			{
				damageMultiplier = 0.6f;
			}
			if(player.statLife > (player.statLifeMax * 0.3) && player.statLife <= (player.statLifeMax * 0.5) )
			{
				damageMultiplier = 0.7f;
			}
			if(player.statLife > (player.statLifeMax * 0.5) && player.statLife <= (player.statLifeMax * 0.7) )
			{
				damageMultiplier = 0.8f;
			}
			if(player.statLife > (player.statLifeMax * 0.7) && player.statLife <= (player.statLifeMax * 0.9) )
			{
				damageMultiplier = 0.9f;
			}
			if(player.statLife > (player.statLifeMax * 0.9))
			{
				damageMultiplier = 1f;
			}


      player.thrownDamage -= damageMultiplier;
			player.meleeDamage -= damageMultiplier;
			player.magicDamage -= damageMultiplier;
			player.rangedDamage -= damageMultiplier;
			player.minionDamage -= damageMultiplier;
			

      player.maxFallSpeed += 0.15f;

        }
		
        public override void ArmorSetShadows(Player player)
		{
			player.armorEffectDrawShadowSubtle = true;
		}		

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "aluminum_bar", 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
