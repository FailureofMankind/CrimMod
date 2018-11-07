using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;         
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.manganese
{
	public class manganese_brick : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Manganese Brick");			
			Tooltip.SetDefault("Salt encrusted brick");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.rare = 1;
            item.value = Item.sellPrice(0, 0, 0, 0);
			item.createTile = mod.TileType("manganese_brick");
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "manganese_ore", 1);
			//recipe.AddIngredient(null, "dry_scales", 1);
			recipe.SetResult(this);
			recipe.AddTile(17);
			recipe.AddRecipe();
        }
	}
}