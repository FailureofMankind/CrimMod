using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons
{
	public class silver_kunai : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Silver Kunai");
			Tooltip.SetDefault("Your average kunai...");
		}
		public override void SetDefaults()
		{
			item.damage = 10;
			item.thrown = true;
			item.width = 14;
			item.height = 36;
			item.useTime = 19;
			item.useAnimation = 19;
			item.noUseGraphic = true;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = 10000;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 9f;
			item.shoot = mod.ProjectileType ("silver_kunai_proj");
            item.consumable = true;
            item.maxStack = 999;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SilverBar);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}
