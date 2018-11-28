using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.ManganeseTurtle
{
	public class seaturtleBag : ModItem
	{
		public override void SetDefaults()
		{
			item.maxStack = 999;
			item.consumable = true;
			item.width = 24;
			item.height = 24;
			item.rare = 0;
			item.expert = true;
			bossBagNPC = mod.NPCType("sea_turtle");
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
			player.QuickSpawnItem(mod.ItemType("manganese_bar"), Main.rand.Next(5,20));   			
			player.QuickSpawnItem(mod.ItemType("DryScales"), Main.rand.Next(35,80));   			
					
			player.QuickSpawnItem(mod.ItemType("dry_capsule"));   //expert drop
		}
	}
}
