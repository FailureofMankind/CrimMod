using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.nettlevine.Buffs
{
	public class nettlevineRanged : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Empowerment: Ranged");
			Description.SetDefault("5% increased ranged damage");
			Main.buffNoSave[Type] = true;
            Main.debuff[Type] = false;
		}

		public override void Update(Player player, ref int buffIndex)
		{
            player.rangedDamage += 0.05f;
        }
	}
}