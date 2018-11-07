using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.ferrium
{
    public class the_sun_scraper : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Sun Scraper");
			Tooltip.SetDefault("'Burn 'em up!'\nShoot a blast of hellfire arrows");
		}

        public override void SetDefaults()
        {
            item.damage = 21;
            item.noMelee = true;
            item.ranged = true;
            item.width = 64;
            item.height = 64;
            item.useTime = 34;
            item.useAnimation = 34;
            item.useStyle = 5;
            item.shoot = 3;
            item.useAmmo = AmmoID.Arrow;
            item.knockBack = 1;
            item.value = Item.sellPrice(0, 2, 0, 0);
            item.rare = 3;
            item.UseSound = SoundID.Item5;
            item.autoReuse = true;
            item.shootSpeed = 10f;

        }
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
          {
              int numberProjectiles = 3;
              for (int i = 0; i < numberProjectiles; i++)
              {
                  Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30));
                  Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, 41, damage, knockBack, player.whoAmI);
              }
              
              return true;
          }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HellstoneBar, 12);
            recipe.AddIngredient(null, "ferrium_plating", 3);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}