using Terraria;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.ManganeseTurtle
{
	[AutoloadEquip(EquipType.Wings)]
	public class DryWings : ModItem
	{

		public override void SetDefaults()
		{

			item.width = 22;
			item.height = 20;
			item.value = 100000;
			item.rare = 11;
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dry Wings");
			Tooltip.SetDefault("With these you can adapt to your surroundings");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 30;
		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.85f;
			ascentWhenRising = 0.45f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 3f;
			constantAscend = 0.135f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 10f;
			acceleration *= 1f;
		}
	}
}
