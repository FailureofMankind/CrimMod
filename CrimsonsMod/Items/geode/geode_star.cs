using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.geode
{
	public class geode_star : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Geode Star");
			Tooltip.SetDefault("Gives enemies 'Crystal Crush' debuff\nEnemies inflicted with this debuff take 10% more damage, which bypasses defense and damage reduction values");
		}
		public override void SetDefaults()
		{
			item.damage = 56;
			item.thrown = true;
			item.width = 52;
			item.height = 52;
			item.useTime = 25;
			item.useAnimation = 25;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.useStyle = 1;
			item.knockBack = 0;
			item.value = 100;
			item.rare = 6;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 18f;
			item.shoot = mod.ProjectileType("geode_star");
            item.consumable = true;
            item.maxStack = 999;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "crystal_geode", 2);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this, 100);
			recipe.AddRecipe();
		}
	}
}
