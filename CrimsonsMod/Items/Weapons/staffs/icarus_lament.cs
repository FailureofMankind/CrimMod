using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons.staffs
{
	public class icarus_lament : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Icarus' Lament");	
			Tooltip.SetDefault("Cast geysers at mouse location\n''");
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults()
		{
			item.damage = 37;
			item.magic = true;
			item.mana = 5;
			item.width = 70;
			item.height = 80;
			item.useTime = 12;
			item.useAnimation = 12;
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
            Projectile.NewProjectile(Main.MouseWorld.X, Main.MouseWorld.Y, speedX, speedY, mod.ProjectileType("icarus_lament"), damage, knockBack, player.whoAmI);
            
            
            return false;

              
		}

		public override void AddRecipes()
		{
	    }
    }
}