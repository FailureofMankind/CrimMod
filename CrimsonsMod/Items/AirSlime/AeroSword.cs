using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.AirSlime
{
	public class AeroSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Aero Katana");
			Tooltip.SetDefault("'extremely light!'");
		}
		public override void SetDefaults()
		{
			item.damage = 13;
			item.melee = true;
			item.width = 52;
			item.height = 52;
			item.useTime = 7;
			item.useAnimation = 7;
			item.useStyle = 1;
			item.useTurn = true;
			item.knockBack = 0;
            item.value = Item.sellPrice(0, 0, 90, 0);
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;

		}
		
		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "AeroGel", 20);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}
