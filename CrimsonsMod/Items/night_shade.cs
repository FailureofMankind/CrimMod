using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items
{
	public class night_shade : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Night Shade");
			Tooltip.SetDefault("dark as night...");
		}


		public override void SetDefaults()
		{

			item.width = 32;
			item.height = 32;
			item.maxStack = 999;
            item.value = Item.sellPrice(0, 0, 75, 0);
		}

//harmode drop


	}
}
