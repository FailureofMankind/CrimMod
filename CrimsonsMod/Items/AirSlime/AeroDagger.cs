using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.AirSlime
{
	public class AeroDagger : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Aero Kunai");//
		}
		public override void SetDefaults()
		{
			item.damage = 37;
			item.thrown = true;
			item.width = 14;
			item.height = 36;
			item.useTime = 19;
			item.useAnimation = 19;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = 10000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 15f;
			item.shoot = 16;
            item.consumable = true;
            item.maxStack = 999;

		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
           int a = Projectile.NewProjectile(position.X, position.Y, speedX, speedY, 16, damage, knockBack, player.whoAmI, 0f, 0f);
           Main.projectile[a].magic = false;
           Main.projectile[a].thrown = true; //converted damage type to thrown here

            
            return false;  
		}


		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "AeroGel", 1);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 75);
            recipe.AddRecipe();
		}
	}
}
