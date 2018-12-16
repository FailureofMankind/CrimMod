using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.geode.armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class geode_pants : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Geode Pants");
			Tooltip.SetDefault("15% increased movement speed");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 18;
			item.value = 10000;
			item.rare = 6;
			item.defense = 6;
		}

		public override void UpdateEquip(Player player)
		{
            player.moveSpeed += 0.15f;
            
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrystalShard, 20);
            recipe.AddIngredient(null, "crystal_geode", 20);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}