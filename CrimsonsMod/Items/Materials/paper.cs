using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Materials
{
	public class paper : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Paper");
			Tooltip.SetDefault("'papers please...'");
		}


		public override void SetDefaults()
		{

			item.width = 56;
			item.height = 64;
			item.maxStack = 999;
            item.value = Item.sellPrice(0, 0, 0, 50);
		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Cactus, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}


	}
}
