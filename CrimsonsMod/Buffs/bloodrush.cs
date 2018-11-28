using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Buffs
{
	public class bloodrush : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Blood Rush");
			Description.SetDefault("You just want to fly off up the sky without wings!");
			Main.buffNoSave[Type] = true;
            Main.debuff[Type] = false;
		}

		public override void Update(Player player, ref int buffIndex)
		{
            player.thrownCrit += 20;
			player.meleeCrit += 20;
			player.rangedCrit += 20;
			player.magicCrit += 20;
            
            player.runAcceleration *= 4f; 
        }
	}
}