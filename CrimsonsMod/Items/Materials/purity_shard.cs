using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Materials
{
	public class purity_shard : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Purity Shard");
			Tooltip.SetDefault("'normal, stable piece of element, delicately balanced between dark and light'");
		}


		public override void SetDefaults()
		{
            item.rare = 1;
			item.width = 32;
			item.height = 32;
			item.maxStack = 999;
            item.value = Item.sellPrice(0, 0, 0, 10);
		}

	}
}
