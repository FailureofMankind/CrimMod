using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.nettlevine
{
	public class poisonVine : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Poison Vine");
			Tooltip.SetDefault("Poisonous but tasty...");
		}


		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.maxStack = 999;
			item.rare = 2;
            item.value = Item.sellPrice(0, 0, 0, 5);
			item.useStyle = 2;
			item.consumable = true;
			item.buffType = 20;
			item.buffTime = 1800;
		}
	}
}
