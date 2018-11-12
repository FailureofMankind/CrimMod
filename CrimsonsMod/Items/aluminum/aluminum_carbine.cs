using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.aluminum
{
    public class aluminum_carbine : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Aluminum Carbine");
			Tooltip.SetDefault("'..it is sometimes confused with carbene..'\n30% chance to not consume ammo");
		}

        public override void SetDefaults()
        {
            item.damage = 6;
            item.noMelee = true;
            item.ranged = true;
            item.width = 72;
            item.height = 36;
            item.scale = 0.6f;
            item.useTime = 13;
            item.useAnimation = 13;
            item.useStyle = 5;
            item.shoot = 10;
            item.useAmmo = AmmoID.Bullet;
            item.knockBack = 3;
            item.value = 1000;
            item.rare = 1;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shootSpeed = 20f;

        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(3));
                speedX = perturbedSpeed.X;
                speedY = perturbedSpeed.Y;
                return true;
            }        

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-45, 0);
		}          

        public override bool ConsumeAmmo(Player player)
            {
                return Main.rand.NextFloat() >= .30f;
            }           
        


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "aluminum_bar", 16);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}