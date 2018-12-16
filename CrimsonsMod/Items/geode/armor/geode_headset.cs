using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.geode.armor
{
	[AutoloadEquip(EquipType.Head)]
	public class geode_headset : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Geode Headset");
			Tooltip.SetDefault("10% increased melee damage and critical strike chance");
            
		}

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 26;
			item.value = 10000;
			item.rare = 6;
			item.defense = 15;
		}

		public override void UpdateEquip(Player player)
		{
            player.meleeDamage += 0.07f;
            player.meleeCrit += 7;
		}
		
        
        public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("geode_scalemail") && legs.type == mod.ItemType("geode_pants");
		}
    

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "10% increased damage reduction, if wearing the Ice Core Shield then you gain +100 max life\nUnder 75% health you release homing crystal shards on being hit";

			player.endurance += 0.1f;
			CrimsonPlayer modplayer = player.GetModPlayer<CrimsonPlayer>(mod);
			
			if(player.statLife < player.statLifeMax*0.75)
			{
				modplayer.geodeMelee = true;
			}
			else
			{
				modplayer.geodeMelee = false;
			}
			
			if(modplayer.iceCoreShield)
			{
				player.statLifeMax2 += 100;
			}
        }
		
        public override void ArmorSetShadows(Player player)
		{
			player.armorEffectDrawShadowSubtle = true;
		}		

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrystalShard, 5);
            recipe.AddIngredient(null, "crystal_geode", 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}