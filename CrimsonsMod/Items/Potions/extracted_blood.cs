using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Potions
{
	public class extracted_blood : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Extracted Blood Sample (Impure)");
			Tooltip.SetDefault("Decreased life regen but increased defense by 12, movement speed and jump boost"
				+ "\n'Drinking this will be alright, but having extra regen buff will help just for the precaution....'");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 30;
			item.maxStack = 30;
			item.rare = 1;
			item.value = 1000;
			item.useStyle = 2;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useTurn = true; 
			item.UseSound = SoundID.Item3;
			item.consumable = true;
			item.buffType = mod.BuffType("blood_poisoning");
			item.buffTime = 18000;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(ItemID.ViciousMushroom);
			recipe.AddIngredient(null, "parasitic_organ", 2);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}