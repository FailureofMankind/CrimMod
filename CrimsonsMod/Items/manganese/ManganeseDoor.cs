using Terraria.ModLoader;

namespace CrimsonsMod.Items.manganese
{
	public class ManganeseDoor : ModItem
	{
		public override void SetDefaults()
		{

			item.width = 24;
			item.height = 48;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.rare = 1;
			item.consumable = true;
			item.value = 0;
			item.createTile = mod.TileType("ManganeseDoorClosed");
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Manganese Door");
			Tooltip.SetDefault("When you open this you feel the ocean breeze flowing in");
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
