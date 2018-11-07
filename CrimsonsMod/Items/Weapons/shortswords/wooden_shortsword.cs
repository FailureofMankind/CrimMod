using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons.shortswords
{
	public class wooden_shortsword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wooden Shortsword");
			Tooltip.SetDefault("For those who want a shortsword playthru........");
		}
		public override void SetDefaults()
		{
			item.damage = 9;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 15;
            item.useTurn = true;
			item.useAnimation = 15;
			item.useStyle = 3;
			item.knockBack = 8;
            item.value = Item.sellPrice(0, 1, 0, 0);
			item.rare = 0;
			item.UseSound = SoundID.Item1;
            item.autoReuse = true;            

		}
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 12);
			recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

	}
}
