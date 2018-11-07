using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.corruption
{
	public class black_sword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Black Hand");
		}
		public override void SetDefaults()
		{
			item.damage = 11;
			item.melee = true;
			item.width = 48;
			item.height = 48;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 1;
			item.knockBack = 5;
            item.value = Item.sellPrice(0, 0, 75, 0);
            item.useTurn = true;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;

		}


		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "vile_core", 10);
            recipe.AddIngredient(ItemID.Ebonwood, 25);
            recipe.AddIngredient(null, "purity_shard", 15);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}
