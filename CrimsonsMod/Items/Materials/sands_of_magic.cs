using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Materials
{
	public class sands_of_magic : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Magic Sand");
			Tooltip.SetDefault("<insert 'is this' meme> waste of fallen stars?");
		}


		public override void SetDefaults()
		{

			item.width = 32;
			item.height = 32;
			item.maxStack = 999;
            item.value = Item.sellPrice(0, 0, 10, 0);
			item.rare = 2;
		}




		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ManaCrystal);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 9);
			recipe.AddRecipe();
		}
	}
}
