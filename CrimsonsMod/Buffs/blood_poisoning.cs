using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Buffs
{
	public class blood_poisoning : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Blood Carnage");
			Description.SetDefault("Your own blood is trying to eat you, but has mutated you for their own benefit");
			Main.buffNoSave[Type] = true;
            Main.debuff[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.statDefense += 12;
            if(player.statLife > 50)
			{
				player.lifeRegen -= 15;
                
				if(player.statLife <= 50)
                {
                    player.lifeRegen += 10;
                }
			
			}
            
		player.moveSpeed *= 1.5f;
		player.jumpBoost = true;
		
		}
	}
}