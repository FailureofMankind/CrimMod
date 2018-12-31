using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items
{
	public class BossBag : GlobalItem
	{
		public override void OpenVanillaBag(string context, Player player, int arg)
        {
			if (context == "bossBag" && arg == 3319) //eoc
            {
				player.QuickSpawnItem(mod.ItemType("bloodTear"), Main.rand.Next(18, 33));
			}
		}
	}
}