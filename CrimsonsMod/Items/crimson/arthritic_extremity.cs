using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.crimson
{
	public class arthritic_extremity : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Arthritic Bone");
			Tooltip.SetDefault("Severed fingers, basically");
		}
		public override void SetDefaults()
		{
			item.damage = 13;
			item.thrown = true;
			item.width = 48;
			item.height = 48;
			item.useTime = 20;
			item.useAnimation = 20;
            item.noMelee = true;
			item.noUseGraphic = true;
			item.useStyle = 1;
			item.knockBack = 0;
			item.value = 100;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 12f;
			item.shoot = mod.ProjectileType ("arthritic_extremity");
            item.consumable = true;
            item.maxStack = 999;

		}

		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "parasitic_organ", 4);
            recipe.AddIngredient(ItemID.Shadewood, 5);
            recipe.AddIngredient(null, "purity_shard", 4);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 100);
            recipe.AddRecipe();
		}
	}
}
