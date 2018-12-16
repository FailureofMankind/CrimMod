using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.geode.armor
{
	[AutoloadEquip(EquipType.Head)]
	public class geode_hood : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Geode Hood");
			Tooltip.SetDefault("7% increased magic damage and critical strike chance");
            
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 20;
			item.value = 10000;
			item.rare = 6;
			item.defense = 4;
		}

		public override void UpdateEquip(Player player)
		{
            player.magicDamage += 0.07f;
            player.magicCrit += 7;
		}
		
        
        public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("geode_scalemail") && legs.type == mod.ItemType("geode_pants");
		}
    

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Increased mana regeneration\n15% reduced mana cost\nHitting enemies with magic weapons will hail hallowed stars on enemies";

			player.manaRegen += 20;
			player.manaRegenBonus += 25;
            player.manaCost *= 0.85f;
			CrimsonPlayer modplayer = player.GetModPlayer<CrimsonPlayer>(mod);
			modplayer.geodeMagic = true;
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