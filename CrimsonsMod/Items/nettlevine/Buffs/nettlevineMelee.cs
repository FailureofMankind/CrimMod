using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.nettlevine.Buffs
{
	public class nettlevineMelee : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Empowerment: Melee");
			Description.SetDefault("12% increased melee damage");
			Main.buffNoSave[Type] = true;
            Main.debuff[Type] = false;
		}

		public override void Update(Player player, ref int buffIndex)
		{
            player.meleeDamage += 0.12f;
        }
	}
}