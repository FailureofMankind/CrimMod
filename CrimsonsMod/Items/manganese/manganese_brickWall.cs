using Terraria.ModLoader;

namespace CrimsonsMod.Items.manganese
{
	public class ManganeseBrickWall : ModItem
	{
		public override void SetDefaults()
		{

			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.rare = 1;
			item.consumable = true;
			item.createWall = mod.WallType("manganese_brickWall");
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Manganese Brick Wall");
			Tooltip.SetDefault("Some filling to keep those monsters out");
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "manganese_brick", 1);
			//recipe.AddIngredient(null, "dry_scales", 1);
			recipe.SetResult(this, 4);
			recipe.AddTile(17);
			recipe.AddRecipe();
        }
	}
}
