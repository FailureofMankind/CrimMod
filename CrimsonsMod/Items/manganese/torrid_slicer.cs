using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.manganese
{
	public class torrid_slicer : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Torrid Slicer");
			Tooltip.SetDefault("'Feels excessively cold......'");
		}
		public override void SetDefaults()
		{
			item.damage = 14;
			item.melee = true;
			item.width = 48;
			item.height = 48;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 5;
            item.value = Item.sellPrice(0, 0,90, 0);
            item.useTurn = true;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;

		}

		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "manganese_bar", 10);
			recipe.AddIngredient(null, "DryScales", 3);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}
