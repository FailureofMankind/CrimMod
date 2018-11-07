using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons.swords
{
	public class CrimsonCutlass : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crimson Cutlass");
			Tooltip.SetDefault("Why is he so obssesed with crimson?");
		}
		public override void SetDefaults()
		{
			item.damage = 503;
			item.melee = true;
			item.width = 60;
			item.height = 60;
			item.scale = 1.7f;
			item.useTime = 25;
			item.useAnimation = 25;
            item.useTurn = true;
			item.useStyle = 1;
			item.knockBack = 4;
            item.value = Item.sellPrice(0, 12, 0, 0);
			item.rare = 5;
			item.UseSound = SoundID.Item1;
            item.autoReuse = true;            
			item.shootSpeed = 10f;

		}
		
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            Projectile.NewProjectile(player.position.X, (int)(player.position.Y - 40), 0, 0, mod.ProjectileType("dagger_explosion"), damage, knockback, player.whoAmI, 0f, 0f);
   //lul
		}

	}
}
