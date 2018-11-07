using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Potions
{
	public class makeshift_ankh_potion : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Makeshift Ankh Potion");
			Tooltip.SetDefault("Grants immunity to some debuffs but also a few buffs");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 30;
			item.maxStack = 30;
			item.rare = 3;
			item.value = 1000;
			item.useStyle = 2;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useTurn = true; 
			item.UseSound = SoundID.Item3;
			item.consumable = true;
			item.buffType = mod.BuffType("ignite");
			item.buffTime = 32400;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater, 2);
			recipe.AddIngredient(ItemID.Daybloom, 5);
			recipe.AddIngredient(ItemID.Waterleaf);
			recipe.AddIngredient(ItemID.Blinkroot);
			recipe.AddIngredient(ItemID.Shiverthorn);
			recipe.AddIngredient(ItemID.Fireblossom);
			recipe.AddIngredient(ItemID.Feather);
			recipe.AddIngredient(null, "DryScales", 5);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}