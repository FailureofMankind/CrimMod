using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Buffs
{
	public class corrupted_mind : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Corrupted Soul");
			Description.SetDefault("Oh the pain in your heart and soul... you can barely walk");
			Main.buffNoSave[Type] = true;
            Main.debuff[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
            player.moveSpeed -= 0.5f;
            player.maxRunSpeed -= 0.5f;

			player.thrownDamage -= 0.15f;
			player.meleeDamage -= 0.15f;
			player.magicDamage -= 0.15f;
			player.rangedDamage -= 0.15f;
			player.minionDamage -= 0.15f;
		
		
		}
	}
}