using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items
{
	public class crushed_lifecrystal : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Life Powder");
			Tooltip.SetDefault("you just crushed its heart!");
		}


		public override void SetDefaults()
		{

			item.width = 32;
			item.height = 32;
			item.maxStack = 999;
            item.value = Item.sellPrice(0, 0, 2, 0);
		}




		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LifeCrystal);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}
