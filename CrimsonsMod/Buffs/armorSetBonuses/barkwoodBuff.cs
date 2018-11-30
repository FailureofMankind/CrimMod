using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Buffs.armorSetBonuses
{
	public class barkwoodBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Barkwood Bonus");
			Description.SetDefault("A leaf guardian is protecting you");
			Main.buffNoSave[Type] = true;
            Main.debuff[Type] = false;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			if(player.ownedProjectileCounts[mod.ProjectileType("barkwoodProj")] <= 0 && player.whoAmI == Main.myPlayer)
			{
				Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, mod.ProjectileType("barkwoodProj"), 0, 0f, player.whoAmI);
			}

		
		}
	}
}