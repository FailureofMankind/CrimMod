using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons.shortswords
{
	public class Minimere : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Minimere");
			Tooltip.SetDefault("'Hurl cats you jerk'");
		}
		public override void SetDefaults()
		{
			item.damage = 304;
			item.melee = true;
			item.width = 58;
			item.height = 58;
			item.useTime = 7;
			item.useAnimation = 7;
			item.useStyle = 3;
			item.knockBack = 3;
			item.useTurn = true;
            item.value = Item.sellPrice(0, 12, 0, 0);
			item.rare = 10;
			item.UseSound = SoundID.Item1;
            item.autoReuse = true;            
	    }
        
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            Projectile.NewProjectile(player.position.X, (int)(player.position.Y + 40), 8, 0, 502, damage, knockback, player.whoAmI, 0f, 0f);
            Projectile.NewProjectile(player.position.X, (int)(player.position.Y + 40), -8, 0, 502, damage, knockback, player.whoAmI, 0f, 0f);
            
			Projectile.NewProjectile(player.position.X, (int)(player.position.Y + 40), 6, 6, 502, damage, knockback, player.whoAmI, 0f, 0f);
            Projectile.NewProjectile(player.position.X, (int)(player.position.Y + 40), 6, -6, 502, damage, knockback, player.whoAmI, 0f, 0f);
            Projectile.NewProjectile(player.position.X, (int)(player.position.Y + 40), -6, 6, 502, damage, knockback, player.whoAmI, 0f, 0f);
            Projectile.NewProjectile(player.position.X, (int)(player.position.Y + 40), -6, -6, 502, damage, knockback, player.whoAmI, 0f, 0f);
        
		}
        
	
	}
}
