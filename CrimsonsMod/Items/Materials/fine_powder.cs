using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Materials
{
	public class fine_powder : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fine Powder");
			Tooltip.SetDefault("has uses....kek");
		}


		public override void SetDefaults()
		{

			item.width = 24;
			item.height = 24;
			item.maxStack = 999;
            item.value = Item.sellPrice(0, 0, 10, 0);
		}




		public override void AddRecipes()
		{
			ModRecipe a = new ModRecipe(mod);
			a.AddIngredient(ItemID.SilverBar, 2);
			a.AddTile(TileID.Anvils);
			a.SetResult(this, 20);
			a.AddRecipe();
		
        	ModRecipe b = new ModRecipe(mod);
			b.AddIngredient(ItemID.TungstenBar, 2);
			b.AddTile(TileID.Anvils);
			b.SetResult(this, 20);
			b.AddRecipe();

        }
	}
}
