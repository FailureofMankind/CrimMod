using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.crimson
{
	public class flesh_mesh : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Flesh Mesh");
			Tooltip.SetDefault("A disc shaped piece of meat, ready to be thrown at");
		}
		public override void SetDefaults()
		{
			item.damage = 15;
			item.thrown = true;
			item.width = 64;
			item.height = 64;
			item.useTime = 22;
			item.useAnimation = 22;
			item.noUseGraphic = true;
            item.noMelee = true;
			item.useStyle = 1;
			item.knockBack = 0;
			item.value = 100;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 12f;
			item.shoot = mod.ProjectileType ("flesh_mesh_proj");
            item.consumable = true;
            item.maxStack = 999;

		}

		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "parasitic_organ", 5);
            recipe.AddIngredient(ItemID.Shadewood, 2);
            recipe.AddIngredient(null, "purity_shard", 2);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
		}
	}
}
