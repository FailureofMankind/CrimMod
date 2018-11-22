using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.purity_wood
{
	public class wand_of_torching : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wand Of Torching");	
			Tooltip.SetDefault("Fire a blast of sparks\n'Upgrade? definitely...'");
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults()
		{
			item.damage = 13;
			item.magic = true;
			item.mana = 4;
			item.width = 42;
			item.height = 42;
			item.useTime = 40;
			item.useAnimation = 40;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 2;
			item.value = 10;
			item.rare = 1;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = 504;
			item.shootSpeed = 13f;
		}
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 9; //This defines how many projectiles to shot. 4 + Main.rand.Next(2)= 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(60)); // This defines the projectiles random spread . 30 degree spread.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return true;
        }  
		
		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WandofSparking);
            recipe.AddIngredient(null, "purity_shard", 10);
			recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}

	}
}