using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.purity_wood
{
	public class bark : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bark");
			Tooltip.SetDefault("used by Bark Pelter\n'boi, you dont just yeet that over there...'");
		}


		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 16;
			item.maxStack = 999;
            item.rare = 1;
            item.ammo = item.type;
            item.consumable = true;
		}

		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 5);
			recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 150);
            recipe.AddRecipe();

            ModRecipe recipe1 = new ModRecipe(mod);
            recipe1.AddIngredient(this, 150);
			recipe1.AddTile(TileID.WorkBenches);
            recipe1.SetResult(ItemID.Wood, 5);
            recipe.AddRecipe();

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
