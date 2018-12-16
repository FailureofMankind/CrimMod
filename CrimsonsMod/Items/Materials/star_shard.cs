using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Materials
{
	public class star_shard : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Star Shard");
			Tooltip.SetDefault("'uugh fallen stars are such a pain in the a-'");
		}


		public override void SetDefaults()
		{

			item.width = 16;
			item.height = 16;
			item.maxStack = 999;
            item.value = Item.sellPrice(0, 0, 0, 0);
			item.rare = 1;
		}




		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FallenStar);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 10);
			recipe.AddRecipe();

			ModRecipe recipee = new ModRecipe(mod);
			recipee.AddIngredient(this, 10);
			recipee.AddTile(TileID.Anvils);
			recipee.SetResult(ItemID.FallenStar);
			recipee.AddRecipe();
		}
	}
}
