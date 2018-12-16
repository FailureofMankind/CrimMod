using Terraria;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.community
{
	[AutoloadEquip(EquipType.Wings)]
	public class failures_wingsk : ModItem
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
			DisplayName.SetDefault("Failure's Agility-Pack");
			Tooltip.SetDefault("'this is STRAIGHT UP awesome!'");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 800;
			player.dash = 1;
            player.maxFallSpeed += 5f;
		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.8f;
			ascentWhenRising = 0.4f;
			maxCanAscendMultiplier = 0.5f;
			maxAscentMultiplier = 5f;
			constantAscend = 0.6f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 20f;
			acceleration *= 5f;
		}
	}
}
