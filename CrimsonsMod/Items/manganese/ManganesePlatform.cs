using Terraria.ModLoader;

namespace CrimsonsMod.Items.manganese
{
	public class ManganesePlatform : ModItem
	{
		public override void SetDefaults()
		{

			item.width = 16;
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
			item.createTile = mod.TileType("ManganesePlatform");
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Manganese Platform");
			Tooltip.SetDefault("This salt encrused platform helps keep you from slipping");
		}
		
		public override void AddRecipes()
		{
			ModRecipe a = new ModRecipe(mod);
			a.AddIngredient(null, "manganese_brick", 1);
			a.SetResult(this, 2);
			a.AddRecipe();
		}
	}
}
