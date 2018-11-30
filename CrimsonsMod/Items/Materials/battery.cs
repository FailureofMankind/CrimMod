using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Materials
{
	public class battery : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Battery");
			Tooltip.SetDefault("used for storing energy....including your soul if it had the right capacity");
		}


		public override void SetDefaults()
		{

			item.width = 24;
			item.height = 24;
			item.maxStack = 999;
            item.value = Item.sellPrice(0, 0, 10, 0);
		}




		/*public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "sands_of_magic", 2);
			recipe.AddIngredient(null, "manganese_bar",3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 6);
			recipe.AddRecipe();
		}*/
	}
}
