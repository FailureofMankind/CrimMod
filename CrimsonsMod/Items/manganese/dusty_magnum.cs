using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.manganese
{
    public class dusty_magnum : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dusty Magnum");
			Tooltip.SetDefault("'Seems like it was owned by someone who lived underwater'\nHas a chance to shoot water spout");
		}

        public override void SetDefaults()
        {
            item.damage = 9;
            item.noMelee = true;
            item.ranged = true;
            item.width = 42;
            item.height = 30;
            item.useTime = 9;
            item.useAnimation = 9;
            item.useStyle = 5;
            item.shoot = 10;
            item.useAmmo = AmmoID.Bullet;
            item.knockBack = 3;
            item.value = Item.sellPrice(0, 0, 95, 0);
            item.rare = 1;
            item.UseSound = SoundID.Item11;
            item.autoReuse = false;
            item.shootSpeed = 14f;

        }


		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
          {
            if(Main.rand.Next(3) == 0)
                {
                    Projectile.NewProjectile(position.X, position.Y, speedX, speedY, 22, damage, 0, player.whoAmI, 0f, 0f);
                    return false;
                }
                else
                {
                    return true;
                }
          }

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-3, 0);
		}          
          

        public override void AddRecipes()
        
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "manganese_bar", 8);
			recipe.AddIngredient(null, "DryScales", 2);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}