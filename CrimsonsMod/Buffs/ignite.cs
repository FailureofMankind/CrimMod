using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Buffs
{
	public class ignite : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Ignited");
			Description.SetDefault("You're on fire, but somehow you are not hurt.......");
			Main.buffNoSave[Type] = true;
            Main.debuff[Type] = false;
		}

		public override void Update(Player player, ref int buffIndex)
		{
           player.meleeDamage *= 1.05f;
           player.thrownDamage *= 1.05f;

           player.buffImmune[BuffID.Chilled] = true;
           player.buffImmune[BuffID.Frostburn] = true;
           player.buffImmune[BuffID.IceBarrier] = true;
        }
	}
}