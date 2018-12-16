using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.geode.armor
{
	[AutoloadEquip(EquipType.Head)]
	public class geode_helmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Geode Helmet");
			Tooltip.SetDefault("3% increased ranged damage and 10% increased ranged critical strike chance");
            
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 20;
			item.value = 10000;
			item.rare = 6;
			item.defense = 8;
		}

		public override void UpdateEquip(Player player)
		{
            player.rangedDamage += 0.03f;
            player.rangedCrit += 10;
		}
		
        
        public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("geode_scalemail") && legs.type == mod.ItemType("geode_pants");
		}
    

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Ranged attacks create illusions of itself that shreds its target into dust";

			CrimsonPlayer modplayer = player.GetModPlayer<CrimsonPlayer>(mod);
			modplayer.geodeRanged = true;
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