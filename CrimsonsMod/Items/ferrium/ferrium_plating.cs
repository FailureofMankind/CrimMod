using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;         
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
namespace CrimsonsMod.Items.ferrium
{
	public class ferrium_plating : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ferrium Plating");			
			Tooltip.SetDefault("useful for reinforcing items for protection against heat and cold");
		}

		public override void SetDefaults()
		{
			item.width = 64;
			item.height = 64;
			item.maxStack = 999;
            item.value = Item.sellPrice(0, 0, 15, 0);
			item.rare = 3;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ferrium_ore", 3);
			recipe.AddIngredient(ItemID.IronBar, 1);
			recipe.SetResult(this);
			recipe.AddTile(17);
			recipe.AddRecipe();

            ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(null, "ferrium_ore", 3);
			recipe1.AddIngredient(ItemID.LeadBar, 1);
			recipe1.SetResult(this);
			recipe1.AddTile(17);
			recipe1.AddRecipe();

        }
    }
}