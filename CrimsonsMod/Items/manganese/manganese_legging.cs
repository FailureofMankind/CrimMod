using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.manganese
{
	[AutoloadEquip(EquipType.Legs)]
	public class manganese_legging : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Manganese Leggings");
			Tooltip.SetDefault("Enables extra jump!");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 18;
			item.value = 100;
			item.rare = 1;
			item.defense = 3;
		}

		public override void UpdateEquip(Player player)
		{
			player.doubleJumpSail = true;
            
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "manganese_bar", 6);
			recipe.AddIngredient(null, "DryScales", 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}