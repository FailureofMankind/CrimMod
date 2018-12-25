using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Materials.Boss
{
	public class bloodTears : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blood Tear");
			Tooltip.SetDefault("'highly viscous liquid that functioned as tear, sweat, and blood for the eyebeast'");
		}
		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 24;
			item.maxStack = 999;
            item.value = Item.sellPrice(0, 0, 1, 0);
            item.rare = 2;
		}
	}
}
