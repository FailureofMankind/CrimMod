using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.ferrium
{
	public class ferrium_pick : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ferrium Pick");
			Tooltip.SetDefault("you can feel the heat emenating from it...");
		}
		public override void SetDefaults()
		{
			item.damage = 7;
			item.melee = true;
			item.width = 64;
			item.height = 64;
            item.scale = 0.7f;
			item.useTime = 4;
			item.useAnimation = 15;
			item.useTurn = true;
			item.useStyle = 1;
			item.knockBack = 0;
            item.pick = 101;
            item.value = Item.sellPrice(0, 0, 80, 0);
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;

		}

		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HellstoneBar, 5);
            recipe.AddIngredient(null, "ferrium_plating", 15);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}
