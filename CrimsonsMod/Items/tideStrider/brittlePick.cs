using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.tideStrider
{
	public class brittlePick : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Brittle Pickaxe");
			Tooltip.SetDefault("'not suitable for combat purposes, but great for an early miner!'");
		}
		public override void SetDefaults()
		{
			item.damage = 1;
			item.melee = true;
			item.width = 64;
			item.height = 64;
            item.scale = 0.7f;
			item.useTime = 7;
			item.useAnimation = 15;
			item.useStyle = 1;
            item.useTurn = true;
			item.knockBack = 0;
            item.pick = 50;
            item.value = Item.sellPrice(0, 0, 80, 0);
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;

		}

		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "tideScale", 12);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}
