using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.tormentor
{
	public class tormentorBag : ModItem
	{
		public override void SetDefaults()
		{
			item.maxStack = 999;
			item.consumable = true;
			item.width = 32;
			item.height = 32;
			item.rare = 0;
			item.expert = true;
			bossBagNPC = mod.NPCType("tormentor_of_souls");
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Treasure Bag");
			Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void OpenBossBag(Player player)
		{
			player.QuickSpawnItem(mod.ItemType("bileSac"), Main.rand.Next(20, 50));
			player.QuickSpawnItem(ItemID.RottenChunk, Main.rand.Next(20, 30));
			player.QuickSpawnItem(mod.ItemType("decayingHusk"));
		}
	}
}
