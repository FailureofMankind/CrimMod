using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons.staffs
{
	public class the_shining : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Shining");	
			Tooltip.SetDefault("'Heres Johnny!!'");
		}

		public override void SetDefaults()
		{
			item.damage = 89;
			item.magic = true;
			item.mana = 5;
			item.width = 70;
			item.height = 80;
			item.useTime = 35;
			item.useAnimation = 35;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 2;
			item.value = 10000;
			item.rare = 6;
			item.UseSound = SoundID.Item117;
			item.autoReuse = true;
			item.shoot = 1;
			item.shootSpeed = 0f;
		}
		
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(Main.MouseWorld.X, Main.MouseWorld.Y, speedX, speedY, mod.ProjectileType("shining"), damage, knockBack, player.whoAmI);
            
            
            return false;
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-5, -5);
		}          


		public override void AddRecipes()
		{
	    }
	}
}
 