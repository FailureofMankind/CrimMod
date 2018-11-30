using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.aluminum
{
	[AutoloadEquip(EquipType.Legs)]
	public class aluminum_legging : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Aluminum Legging");
			Tooltip.SetDefault("5% increased movement speed");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 18;
			item.value = 10000;
			item.rare = 1;
			item.defense = 2;
		}

		public override void UpdateEquip(Player player)
		{
            player.moveSpeed += 0.05f;
            
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "aluminum_bar", 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}