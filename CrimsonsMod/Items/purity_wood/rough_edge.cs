using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.purity_wood
{
	public class rough_edge : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rough Edge");
		}
		public override void SetDefaults()
		{
			item.damage = 10;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 17;
			item.useAnimation = 17;
			item.useStyle = 1;
			item.knockBack = 5;
            item.value = Item.sellPrice(0, 0, 0, 10);
            item.useTurn = true;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;

		}


		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 25);
            recipe.AddIngredient(null, "purity_shard", 10);
			recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}
