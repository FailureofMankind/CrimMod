using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Materials.postml
{
	public class nightmare_infection : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nightmare Infection");
			Tooltip.SetDefault("'unbearable thoughts arise as you possess this item...'");
		}


		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.maxStack = 999;
            item.value = Item.sellPrice(0, 0, 10, 0);
            item.rare = 9;
		}
	}
}
