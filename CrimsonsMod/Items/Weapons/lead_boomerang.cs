using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons
{
	public class lead_boomerang : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lead Boomerang");
			Tooltip.SetDefault("Has a homing ability!");
		}
		public override void SetDefaults()
		{
			item.damage = 14;
			item.thrown = true;
			item.width = 18;
			item.height = 32;
			item.useTime = 18;
			item.useAnimation = 18;
			item.noUseGraphic = true;
			item.useStyle = 1;
			item.knockBack = 4;
            item.value = Item.sellPrice(0, 1, 0, 0);
			item.value = 10000;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 10f;
			item.shoot = mod.ProjectileType ("lead_boomerang");

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LeadBar, 7);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
