using Terraria.ModLoader;

namespace CrimsonsMod.Items.manganese
{
	public class ManganeseChair : ModItem
	{
		public override void SetDefaults()
		{

			item.width = 16;
			item.height = 32;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 15;
			item.useStyle = 1;
			item.rare = 1;
			item.consumable = true;
			item.value = 0;
			item.createTile = mod.TileType("ManganeseChair");
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Manganese Chair");
			Tooltip.SetDefault("Rough but oddly comfy");
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "manganese_brick", 4);
			//recipe.AddIngredient(null, "dry_scales", 1);
			recipe.SetResult(this);
			recipe.AddTile(17);
			recipe.AddRecipe();
        }
	}
}
