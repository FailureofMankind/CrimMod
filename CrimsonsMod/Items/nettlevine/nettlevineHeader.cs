using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.nettlevine
{
	[AutoloadEquip(EquipType.Head)]
	public class nettlevineHeader : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Nettlevine Header");
			Tooltip.SetDefault("10% increased melee/ranged crit chance");            
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 28;
            item.value = Item.sellPrice(0, 0, 5, 0);
			item.rare = 3;
			item.defense = 5;
		}

		public override void UpdateEquip(Player player)
		{
            player.rangedCrit += 10;
            player.meleeCrit += 10;
    	}
		
        
        public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("nettlevineScalemail") && legs.type == mod.ItemType("nettlevineLegging");
		}
    

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Melee damage has a chance to empower ranged damage and vice versa\nMelee and ranged attacks have a chance to inflict venom";

			CrimsonPlayer modplayer = player.GetModPlayer<CrimsonPlayer>(mod);
            modplayer.nettlevineArmor = true;
        }
		
        public override void ArmorSetShadows(Player player)
		{
			player.armorEffectDrawOutlines = true;
		}		

		public override void AddRecipes()
		{
			ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(null, "poisonVine", 5);
			recipe1.AddIngredient(ItemID.Vine, 6);
			recipe1.AddIngredient(ItemID.JungleSpores, 5);
			recipe1.AddIngredient(ItemID.Stinger, 1);
			recipe1.AddIngredient(ItemID.ShadowScale, 5);
			recipe1.AddTile(TileID.Anvils);
			recipe1.SetResult(this);
			recipe1.AddRecipe();

			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient(null, "poisonVine", 5);
			recipe2.AddIngredient(ItemID.Vine, 6);
			recipe2.AddIngredient(ItemID.JungleSpores, 5);
			recipe2.AddIngredient(ItemID.Stinger, 1);
			recipe2.AddIngredient(ItemID.TissueSample, 5);
			recipe2.AddTile(TileID.Anvils);
			recipe2.SetResult(this);
			recipe2.AddRecipe();
		}
	}
}