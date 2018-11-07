using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons
{
    public class speed_slayer : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Speed Slayer");
			Tooltip.SetDefault("Converts hellfire arrows into meteors");
		}

        public override void SetDefaults()
        {
            item.damage = 15;
            item.noMelee = true;
            item.ranged = true;
            item.width = 30;
            item.height = 42;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 5;
            item.shoot = 12;
            item.useAmmo = AmmoID.Arrow;
            item.knockBack = 0;
            item.value = Item.sellPrice(0, 2, 95, 0);
            item.rare = 1;
            item.UseSound = SoundID.Item5;
            item.autoReuse = true;
            item.shootSpeed = 10f;

        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if (type == ProjectileID.HellfireArrow) // or ProjectileID.WoodenArrowFriendly
			{
				type = 424;
			}
			return true; // return true to allow tmodloader to call Projectile.NewProjectile as normal
		}
		
        
        public override Vector2? HoldoutOffset()
		{
			return new Vector2(-5, 0);
		}          


    }
}