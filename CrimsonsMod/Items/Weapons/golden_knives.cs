using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons
{
	public class golden_knives : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Golden Knives");
			Tooltip.SetDefault("The knives have a chance to inflict Midas\nMay shatter armor of enemies");
		}
		public override void SetDefaults()
		{
			item.damage = 19;
			item.thrown = true;
			item.width = 14;
			item.height = 36;
			item.useTime = 13;
			item.useAnimation = 13;
			item.noUseGraphic = true;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 5f;
			item.shoot = mod.ProjectileType ("gold_knives");
            item.consumable = true;
            item.maxStack = 999;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBar);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 65);
			recipe.AddRecipe();
		}
	}
}
