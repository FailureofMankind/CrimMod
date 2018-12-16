using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Materials.hardmode
{
	public class crystal_geode : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crystal Geode");
			Tooltip.SetDefault("'remains of an age old civilization of light creatures...'");
		}


		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.maxStack = 999;
            item.value = Item.sellPrice(0, 0, 0, 50);
            item.rare = 6;
		}
	}
}
