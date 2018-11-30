using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons
{
	public class true_polaris : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("True Polaris");
			Tooltip.SetDefault("'Wait wasnt the north star just over ther-'\nYou are holding the destruction of countless civilizations\nExplodes into beams on impact");
		}
		public override void SetDefaults()
		{
			item.damage = 180;
			item.thrown = true;
			item.width = 84;
			item.height = 104;
			item.useTime = 15;
			item.useAnimation = 15;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.useStyle = 1;
			item.knockBack = 6;
            item.value = Item.sellPrice(1, 0, 0, 0);
			item.value = 10000;
			item.rare = 10;
			item.UseSound = SoundID.Item116;
			item.autoReuse = true;
			item.shootSpeed = 40f;
			item.shoot = mod.ProjectileType ("true_polaris");
		}
		
		
		/*public override void AddRecipes()
		{
            ModRecipe crimson = new ModRecipe(mod);
            crimson.AddIngredient(null, "polaris");
            crimson.AddIngredient(null, "star_scourge");
            crimson.AddIngredient(ItemID.IceBoomerang);
            crimson.AddIngredient(ItemID.Flamarang);
            crimson.AddIngredient(ItemID.VampireKnives);
            crimson.AddIngredient(3467, 10);
			crimson.AddIngredient(3456, 10);
			crimson.AddIngredient(3457, 10);
			crimson.AddIngredient(3458, 10);
			crimson.AddIngredient(3459, 10);
			crimson.AddTile(TileID.LunarCraftingStation);
            crimson.SetResult(this);
            crimson.AddRecipe();
            
			ModRecipe corrupt = new ModRecipe(mod);
            corrupt.AddIngredient(null, "polaris");
            corrupt.AddIngredient(null, "star_scourge");
            corrupt.AddIngredient(ItemID.IceBoomerang);
            corrupt.AddIngredient(ItemID.Flamarang);
            corrupt.AddIngredient(1571); //scourge of the corruptor
            corrupt.AddIngredient(3467, 10);
			corrupt.AddIngredient(3456, 10);
			corrupt.AddIngredient(3457, 10);
			corrupt.AddIngredient(3458, 10);
			corrupt.AddIngredient(3459, 10);
			corrupt.AddTile(TileID.LunarCraftingStation);
            corrupt.SetResult(this);
            corrupt.AddRecipe();
		}*/
	}
}
