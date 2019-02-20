using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.tideStrider.Buffs
{
	public class aquaticRush : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Aquatic Rush");
			Description.SetDefault("Your flight response has been activated!");
			Main.buffNoSave[Type] = true;
            Main.debuff[Type] = false;
		}

		public override void Update(Player player, ref int buffIndex)
		{
            player.moveSpeed += 0.3f;
            player.maxRunSpeed += 1.7f;
			player.meleeSpeed += 0.35f;
        }
	}
}