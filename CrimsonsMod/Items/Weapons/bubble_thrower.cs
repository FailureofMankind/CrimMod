using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons
{
    public class bubble_thrower : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bubblethrower");
			Tooltip.SetDefault("'who knew bubbles were that dangerous?'\n66% chance to not consume gel");
		}

        public override void SetDefaults()
        {
            item.damage = 8;
            item.noMelee = true;
            item.ranged = true;
            item.width = 54;
            item.height = 16;
            item.useTime = 4;
            item.useAnimation = 4;
            item.useStyle = 5;
            item.shoot = ProjectileID.Bubble;
            item.useAmmo = AmmoID.Gel;
            item.knockBack = 0;
            item.value = 1000;
            item.rare = 1;
            item.UseSound = SoundID.Item95;
            item.autoReuse = true;
            item.shootSpeed = 20f;

        }

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
          {
              int numberProjectiles = 3; //This defines how many projectiles to shot. 4 + Main.rand.Next(2)= 4 or 5 shots
              for (int i = 0; i < numberProjectiles; i++)
              {
                  Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(15)); // This defines the projectiles random spread . 30 degree spread.
                  Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
              }
              return false;
          }

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-10, 0);
		}       

        public override bool ConsumeAmmo(Player player)
            {
                return Main.rand.NextFloat() >= .66f;
            }           
           


    }
}