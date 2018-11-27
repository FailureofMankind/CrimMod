using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.purity_wood.armor
{
	[AutoloadEquip(EquipType.Head)]
	public class bark_helmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Barkwood Header");
			Tooltip.SetDefault("+1 minion slot");
            
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 28;
			item.value = 10000;
			item.rare = 1;
			item.defense = 1;
		}

		public override void UpdateEquip(Player player)
		{
            player.maxMinions += 1;
		}
		
        
        public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("bark_armor") && legs.type == mod.ItemType("bark_legging");
		}
    

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "You have a leaf guardian protecting you";

			player.AddBuff(mod.BuffType("barkwoodBuff"), 1, true);
			CrimsonPlayer modplayer = player.GetModPlayer<CrimsonPlayer>(mod);
			modplayer.barkwoodSet = true;
        }
		
        public override void ArmorSetShadows(Player player)
		{
			player.armorEffectDrawShadowSubtle = true;
		}		

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WoodHelmet);
            recipe.AddIngredient(null, "purity_shard", 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}