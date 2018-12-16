using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.geode.armor
{
	[AutoloadEquip(EquipType.Head)]
	public class geode_mask : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Geode Mask");
			Tooltip.SetDefault("7% increased throwing damage and critical strike chance");
            
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 20;
			item.value = 10000;
			item.rare = 6;
			item.defense = 12;
		}

		public override void UpdateEquip(Player player)
		{
            player.thrownDamage += 0.07f;
            player.thrownCrit += 7;
		}
		
        
        public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("geode_scalemail") && legs.type == mod.ItemType("geode_pants");
		}
    

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "13% increased throwing damage\nEvery fifth hit from any throwing weapon will heal you";

            player.thrownDamage += 0.13f;
			CrimsonPlayer modplayer = player.GetModPlayer<CrimsonPlayer>(mod);
			modplayer.geodeThrowing = true;
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