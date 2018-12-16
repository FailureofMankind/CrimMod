using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Materials.postml
{
	public class demonic_blood : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Demonic Blood");
			Tooltip.SetDefault("'blood spilled from demons that ruled the overworld millenia ago...'");
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
