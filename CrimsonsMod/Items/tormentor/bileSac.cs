using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.tormentor
{
	public class bileSac : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bile Sac");
			Tooltip.SetDefault("Corrosive to touch");
		}
		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.maxStack = 999;
			item.rare = 3;
            item.value = Item.sellPrice(0, 0, 0, 30);
		}
	}
}
