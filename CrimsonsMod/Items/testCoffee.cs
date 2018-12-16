using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items
{
	public class testCoffee : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Test Coffe");
			Tooltip.SetDefault("kek");
        }
		public override void SetDefaults()
		{
			item.damage = 999;
			item.width = 40;
			item.height = 40;
			item.useTime = 3;
			item.useAnimation = 3;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 0;
			item.rare = -2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 10f;
            item.shoot = 1;
		}        
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
          {
            int a = Projectile.NewProjectile(position.X, position.Y, speedX, speedY, Main.rand.Next(1, 713), damage, knockBack, player.whoAmI);
            Main.projectile[a].hostile = false;
            Main.projectile[a].friendly = true;
            
            return false;
          }

	}
}
