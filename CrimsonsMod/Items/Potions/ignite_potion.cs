using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Potions
{
	public class ignite_potion : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Igniting Potion");
			Tooltip.SetDefault("Increased melee and throwing damage by 5% and immune to most cold debuffs, but also negates frozen turtle shell effect...");
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
			item.buffTime = 21600;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(ItemID.Gel, 10);
			recipe.AddIngredient(ItemID.Fireblossom);
			recipe.AddIngredient(ItemID.Obsidian);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}