using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Buffs
{
	public class thrower : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Precise Coordination");
			Description.SetDefault("Increased throwing damage");
			Main.buffNoSave[Type] = true;
            Main.debuff[Type] = false;
		}

		public override void Update(Player player, ref int buffIndex)
		{
           player.thrownDamage *= 1.05f;
           player.thrownCrit += 5;
        }
	}
}