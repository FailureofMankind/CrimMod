using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Materials
{
	public class parasitic_organ : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Organoid Organism");
			Tooltip.SetDefault("'touching it won't hurt much, other than losing control of your limbs...'");
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
