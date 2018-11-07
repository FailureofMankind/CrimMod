using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Materials
{
	public class vile_core : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Vile Core");
			Tooltip.SetDefault("'... we will get your heart and then get your soul...'");
		}


		public override void SetDefaults()
		{

			item.width = 32;
			item.height = 32;
			item.rare = 1;
			item.maxStack = 999;
            item.value = Item.sellPrice(0, 0, 0, 20);
		}

	}
}
