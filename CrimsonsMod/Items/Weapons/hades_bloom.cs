using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons
{
	public class hades_bloom : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hades Bloom");	
			Tooltip.SetDefault("'Tend with evil'");
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults()
		{
			item.damage = 24;
			item.magic = true;
			item.mana = 5;
			item.width = 64;
			item.height = 64;
			item.useTime = 24;
			item.useAnimation = 24;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 2;
			item.value = 10000;
			item.rare = 5;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = 1;
			item.shootSpeed = 9f;
		}
		
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("hades_bloom_X"), damage, knockBack, player.whoAmI, 0f, 0f);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("hades_bloom_Y"), damage, knockBack, player.whoAmI, 0f, 0f);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("hades_bloom"), damage, knockBack, player.whoAmI, 0f, 0f);
            
            
            return false;  
		}
	}
}