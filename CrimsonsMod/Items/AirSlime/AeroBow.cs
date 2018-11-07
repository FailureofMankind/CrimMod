using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.AirSlime
{
    public class AeroBow : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hurricane");
		}

        public override void SetDefaults()
        {
            item.damage = 12;
            item.noMelee = true;
            item.ranged = true;
            item.width = 68;
            item.height = 128;
            item.useTime = 22;
            item.useAnimation = 22;
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
                  Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(60));
                  int a = Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, mod.ProjectileType("AeroSpell"), damage, knockBack, player.whoAmI);
                  Main.projectile[a].magic = false;
                  Main.projectile[a].ranged = true;
              }
              
              return true;
          }

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-5, 0);
		}          


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "AeroGel", 14);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}