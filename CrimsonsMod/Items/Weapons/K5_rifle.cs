using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons
{
	public class K5_rifle : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("K5 Rifle");	
			Tooltip.SetDefault("'Absolutely astonishing......'");
		}

		public override void SetDefaults()
		{
			item.damage = 43;
			item.magic = true;
			item.mana = 15;
			item.width = 64;
			item.height = 26;
			item.useTime = 3;
			item.useAnimation = 20;
            item.reuseDelay = 20;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 6;
			item.UseSound = SoundID.Item67;
			item.autoReuse = true;
			item.shoot = 1;
			item.shootSpeed = 25f;
		}
		
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
           int a = Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.GreenLaser, damage, knockBack, player.whoAmI, 0f, 0f);
           Main.projectile[a].penetrate = 1;
            
            
            return false;  
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-10, 0);
		}          

		public override void AddRecipes()
		{
	    }
    }
}