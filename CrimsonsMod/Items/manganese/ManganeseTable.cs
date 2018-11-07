using Terraria.ModLoader;

namespace CrimsonsMod.Items.manganese
{
	public class ManganeseTable : ModItem
	{
		public override void SetDefaults()
		{

			item.width = 48;
			item.height = 32;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 15;
			item.useStyle = 1;
			item.rare = 1;
			item.consumable = true;
			item.value = 2000;
			item.createTile = mod.TileType("ManganeseTable");
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Manganese Table");
			Tooltip.SetDefault("Where the salt and pepper go");
		}
		
		public override void AddRecipes()
		{
			ModRecipe a = new ModRecipe(mod);
			a.AddIngredient(null, "manganese_brick", 6);
			a.SetResult(this);
			a.AddRecipe();
		}
	}
}
