using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.geode.armor
{
	[AutoloadEquip(EquipType.Body)]
	public class geode_scalemail : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Geode Scalemail");
			Tooltip.SetDefault("Increased life regeneration");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 20;
			item.value = 10000;
			item.rare = 6;
			item.defense = 25;
		}

		public override void UpdateEquip(Player player)
		{
           player.lifeRegen += 5;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrystalShard, 20);
            recipe.AddIngredient(null, "crystal_geode", 30);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}