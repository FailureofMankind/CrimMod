using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Buffs
{
	public class makeshift_ankh : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Makeshift Ankh Effect");
			Description.SetDefault("Immune to not only debuffs but also beneficial buffs");
			Main.buffNoSave[Type] = true;
            Main.debuff[Type] = false;
		}

		public override void Update(Player player, ref int buffIndex)
		{
           player.buffImmune[BuffID.Frostburn] = true;
           player.buffImmune[BuffID.Featherfall] = true;
           player.buffImmune[BuffID.Invisibility] = true;
           player.buffImmune[BuffID.OnFire] = true;
           player.buffImmune[BuffID.Poisoned] = true;
           player.buffImmune[BuffID.Tipsy] = true;
           player.buffImmune[BuffID.Confused] = true;
           player.buffImmune[BuffID.Burning] = true;

        }
	}
}