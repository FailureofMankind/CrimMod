using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.aluminum
{
	[AutoloadEquip(EquipType.Body)]
	public class aluminum_armor : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Aluminum Vest");
			Tooltip.SetDefault("+50 max mana and life");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 20;
			item.value = 10000;
			item.rare = 1;
			item.defense = 3;
		}

		public override void UpdateEquip(Player player)
		{
        	player.statLifeMax2 += 50;
			player.statManaMax2 +=50; 
		   
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "aluminum_bar", 16);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}