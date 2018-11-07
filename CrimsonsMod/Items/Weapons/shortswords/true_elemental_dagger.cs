using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons.shortswords
{
	public class true_elemental_dagger : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("True Elemental Dagger");
			Tooltip.SetDefault("'without shortswords, life ain't worth livin..'\nShoots a high energy projectile that explodes into fireballs and inflicts several debuffs\nHitting enemies with the blade causes an explosion");
		}
		public override void SetDefaults()
		{
			item.damage = 82;
			item.melee = true;
			item.width = 76;
			item.height = 76;
			item.useTime = 14;
			item.useAnimation = 14;
            item.scale = 0.7f;
			item.useStyle = 3;
			item.knockBack = 4;
            item.value = Item.sellPrice(0, 40, 0, 0);
			item.rare = 8;
			item.UseSound = SoundID.Item60;
            item.autoReuse = true;    
			item.shoot = mod.ProjectileType("true_dagger");
			item.shootSpeed = 7f;


		}
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            Projectile.NewProjectile(player.position.X, (int)(player.position.Y + 40), 0, 0, mod.ProjectileType("dagger_explosion"), damage, knockback, player.whoAmI, 0f, 0f);
        //kaboom
		}

			public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 10); // luminite bar
            recipe.AddIngredient(null, "terra_dagger");
            recipe.AddIngredient(null, "Starstriker");
            recipe.AddIngredient(null, "Influx_Shortsword");
            recipe.AddIngredient(null, "Minimere");
            recipe.AddIngredient(null, "Halo");
			recipe.AddTile(TileID.LunarCraftingStation); //ancient manipulator, jeez what the fuk is with these misleading names??
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

	
	
	
	
	
	
	
	}
}
