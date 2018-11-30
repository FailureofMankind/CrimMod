using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Materials
{
	public class dawn_shard : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dawn Shard");
			Tooltip.SetDefault("'never fail to see the evil cloaked in light...'");
		}


		public override void SetDefaults()
		{

			item.width = 32;
			item.height = 32;
			item.maxStack = 999;
            item.value = Item.sellPrice(0, 0, 75, 0);
            item.rare = 5;
		}

//harmode drop


	}
}
