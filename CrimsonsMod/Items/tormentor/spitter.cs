using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.tormentor
{
    public class spitter : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spitter");
			Tooltip.SetDefault("'cool and good.'\nShoot magic vile shots that slow down as it hits enemies");
		}

        public override void SetDefaults()
        {
            item.damage = 20;
            item.noMelee = true;
            item.magic = true;
            item.mana = 6;
            item.width = 32;
            item.height = 20;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 5;
            item.knockBack = 3;
            item.value = Item.sellPrice(0, 0, 30, 0);
            item.rare = 3;
            item.UseSound = SoundID.Item75;
            item.autoReuse = true;
            item.shootSpeed = 10f;
            item.shoot = mod.ProjectileType("spitterMagProj");
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
			float numberProjectiles2 = 3; // This defines how many projectiles to shot
			float rotation = MathHelper.ToRadians(20);
			position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f; //this defines the distance of the projectiles form the player when the projectile spawns
			for (int i = 0; i < numberProjectiles2; i++)
				{
					Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles2 - 1)) * 0.5f); // This defines the projectile roatation and speed
					int a = Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
				}
			return false;
		}        
        public override void AddRecipes()        
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DemoniteBar, 15);
            recipe.AddIngredient(null, "bileSac", 10);
			recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}