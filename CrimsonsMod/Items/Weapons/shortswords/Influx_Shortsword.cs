using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons.shortswords
{
	public class Influx_Shortsword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Influx ");
			Tooltip.SetDefault("Martians don't got nothin' on this");
		}
		public override void SetDefaults()
		{
			item.damage = 112;
			item.melee = true;
			item.width = 58;
			item.height = 58;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 3;
			item.knockBack = 3;
            item.value = Item.sellPrice(0, 12, 0, 0);
			item.rare = 8;
			item.UseSound = SoundID.Item1;
            item.autoReuse = true;            
			item.shootSpeed = 7f;
			item.shoot = mod.ProjectileType ("blank");
	    }
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 1;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30));
                int a = Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, 451, damage, knockBack, player.whoAmI);
				Main.projectile[a].timeLeft = 40;
            }
              
            return true;

		}
	}
}
