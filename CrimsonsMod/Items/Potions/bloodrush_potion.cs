using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Potions
{
	public class bloodrush_potion : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bloodrush Potion");
			Tooltip.SetDefault("Increases wing flight time and critical strike chance by 20%\n'REEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE SO ANGRY'");
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
			item.buffType = mod.BuffType("bloodrush");
			item.buffTime = 18000;
		}

		public override void AddRecipes()
		{
			ModRecipe a = new ModRecipe(mod);
			a.AddIngredient(ItemID.BottledWater);
			a.AddIngredient(null, "crushed_lifecrystal", 10);
			a.AddIngredient(null, "vile_core", 5);
			a.AddTile(TileID.Bottles);
			a.SetResult(this);
			a.AddRecipe();
			ModRecipe b = new ModRecipe(mod);
			b.AddIngredient(ItemID.BottledWater);
			b.AddIngredient(null, "crushed_lifecrystal", 10);
			b.AddIngredient(null, "parasitic_organ", 5);
			b.AddTile(TileID.Bottles);
			b.SetResult(this);
			b.AddRecipe();
		}
	}
}