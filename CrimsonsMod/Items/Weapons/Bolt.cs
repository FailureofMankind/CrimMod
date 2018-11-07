using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons
{
    public class Bolt : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bolt");
			Tooltip.SetDefault("Shoots 3 arrows per volley\nHas a chance of shooting a star");
		}

        public override void SetDefaults()
        {
            item.damage = 29;
            item.noMelee = true;
            item.ranged = true;
            item.width = 30;
            item.height = 42;
            item.useTime = 8;
            item.useAnimation = 15;
            item.useStyle = 5;
            item.reuseDelay = 20;
            item.shoot = 12;
            item.useAmmo = AmmoID.Arrow;
            item.knockBack = 0;
            item.value = Item.sellPrice(0, 2, 0, 0);
            item.rare = 3;
            item.UseSound = SoundID.DD2_SkyDragonsFuryShot;
            item.autoReuse = true;
            item.shootSpeed = 10f;

        }

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
          {
            if(Main.rand.Next(3) == 0)
                {
                    int a = Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("sun_star"), damage, 3, player.whoAmI, 0f, 0f);
                    Main.projectile[a].tileCollide = false;
                    Main.projectile[a].ranged = true;
                    Main.projectile[a].penetrate = -1;
                    
                    return false;
                }
                else
                {
                    return true;
                }
          }
    }
}