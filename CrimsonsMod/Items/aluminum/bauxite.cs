using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.aluminum
{
	public class bauxite : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bauxite");
			Tooltip.SetDefault("'A hard and tough ball of steel'\nHas a chance to release projections of itself");

			// These are all related to gamepad controls and don't seem to affect anything else
			ItemID.Sets.Yoyo[item.type] = true;
			ItemID.Sets.GamepadExtraRange[item.type] = 15;
			ItemID.Sets.GamepadSmartQuickReach[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.width = 24;
			item.height = 20;
			item.useAnimation = 5;
			item.useTime = 5;
			item.shootSpeed = 15f;
			item.knockBack = 5f;
			item.damage = 20;
			item.rare = 2;

			item.melee = true;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;

			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(silver: 99);
			item.shoot = mod.ProjectileType("bauxite");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "aluminum_bar", 8);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}


