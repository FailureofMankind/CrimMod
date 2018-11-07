using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Potions
{
	public class heartache_potion : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Heartache Potion (Impure)");
			Tooltip.SetDefault("Decreases movement speed and max speed by 50% but increased damage by 15%\n'...we corrupt your soul and take away your sanity..'");
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
			item.buffType = mod.BuffType("corrupted_mind");
			item.buffTime = 18000;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(ItemID.VileMushroom);
			recipe.AddIngredient(null, "vile_core", 2);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}