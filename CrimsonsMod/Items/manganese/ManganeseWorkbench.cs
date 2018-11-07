using Terraria.ModLoader;

namespace CrimsonsMod.Items.manganese
{
	public class ManganeseWorkbench : ModItem
	{
		public override void SetDefaults()
		{

			item.width = 32;
			item.height = 16;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 15;
			item.useStyle = 1;
			item.rare = 1;
			item.consumable = true;
			item.value = 2000;
			item.createTile = mod.TileType("ManganeseWorkbench");
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Manganese Work Bench");
			Tooltip.SetDefault("The same thing people used to craft back before the water dried up");
		}
		
		public override void AddRecipes()
		{
			ModRecipe a = new ModRecipe(mod);
			a.AddIngredient(null, "manganese_brick", 4);
			a.SetResult(this);
			a.AddRecipe();
		}
	}
}
