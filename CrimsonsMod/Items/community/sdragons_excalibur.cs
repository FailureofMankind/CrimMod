using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.community
{
	public class sdragons_excalibur : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sdragons' Excali B ur");
			Tooltip.SetDefault("'lol make it an emoji'");
		}
		public override void SetDefaults()
		{
			item.damage = 69;
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 14;
			item.useAnimation = 14;
			item.useStyle = 1;
			item.knockBack = 5;
            item.value = Item.sellPrice(0, 0, 0, 0);
			item.rare = -1;
			item.UseSound = SoundID.Item1;
            item.autoReuse = true;            
			item.shootSpeed = 50f;
            item.shoot = 79;

		}
        
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
          {
              int numberProjectiles = Main.rand.Next(50);
              for (int i = 0; i < numberProjectiles; i++)
              {
                  Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(180));
                  Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
              }
              
              return true;
          }
 
	}
}
