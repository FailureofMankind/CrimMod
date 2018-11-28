using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.purity_wood.armor
{
	[AutoloadEquip(EquipType.Body)]
	public class bark_armor : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Barkwood Chestplate");
			Tooltip.SetDefault("7% increased minion damage");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 20;
			item.value = 10000;
			item.rare = 1;
			item.defense = 2;
		}

		public override void UpdateEquip(Player player)
		{
		   player.minionDamage += 0.07f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WoodBreastplate);
            recipe.AddIngredient(null, "purity_shard", 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}