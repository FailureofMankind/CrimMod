using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons
{
	public class palladium_disk : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Palladium Disk");
			Tooltip.SetDefault("Bounces randomly when hitting enemies\nChance to heal you on enemy hits");
		}
		public override void SetDefaults()
		{
			item.damage = 30;
			item.thrown = true;
			item.width = 18;
			item.height = 32;
			item.useTime = 18;
			item.useAnimation = 18;
			item.noUseGraphic = true;
			item.useStyle = 1;
			item.noMelee = true;
			item.knockBack = 4;
            item.value = Item.sellPrice(0, 0, 60, 0);
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 20f;
			item.shoot = mod.ProjectileType ("palladium_disk");

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PalladiumBar, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
