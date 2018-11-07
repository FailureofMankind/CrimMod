using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons.shortswords
{
	public class Starstriker : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Starstriker");
			Tooltip.SetDefault("Starstruck huh?");
		}
		public override void SetDefaults()
		{
			item.damage = 17;
			item.melee = true;
			item.width = 58;
			item.height = 58;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 3;
			item.knockBack = 3;
            item.value = Item.sellPrice(0, 12, 0, 0);
			item.rare = 3;
			item.UseSound = SoundID.Item1;
            item.autoReuse = true;            
			item.shootSpeed = 5f;
			item.shoot = mod.ProjectileType ("blank");
	    }
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 1;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30));
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, 9, damage, knockBack, player.whoAmI);
            }
              
            return true;

		}
	
	
	
	
	
	}
}
