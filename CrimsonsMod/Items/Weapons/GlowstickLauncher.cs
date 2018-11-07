using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons
{
    public class GlowstickLauncher : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Glowstick Launcher");
			Tooltip.SetDefault("Glowsticks for everyone!!!");
		}

        public override void SetDefaults()
        {
            item.noMelee = true;
            item.width = 60;
            item.height = 40;
            item.useTime = 5;
            item.useAnimation = 5;
            item.useStyle = 5;
            item.shoot = 10;
            item.value = 1000;
            item.rare = 3;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shootSpeed = 20f;

        }

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
          {
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, 50, damage, knockBack, player.whoAmI);
            
            return false;
          }

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-15, 0);
		}          

        


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "AeroGel", 20);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}