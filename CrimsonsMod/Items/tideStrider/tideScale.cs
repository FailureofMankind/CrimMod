using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.tideStrider
{
	public class tideScale : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tide Scale");
			Tooltip.SetDefault("Similar to gelatine but harder...");
		}


		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 26;
			item.maxStack = 999;
			item.rare = 1;
            item.value = Item.sellPrice(0, 0, 0, 30);
		}
	}
}
