using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.corruption
{
	public class shade_stave : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shade Stave");	
			Tooltip.SetDefault("Move your cursor at the enemies to eat away at their flesh");
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults()
		{
			item.damage = 12;
			item.magic = true;
			item.mana = 4;
			item.width = 82;
			item.height = 80;
			item.useTime = 13;
			item.useAnimation = 13;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.NPCHit13;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("rot");
			item.shootSpeed = 1f;
		}
		
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(Main.MouseWorld.X, Main.MouseWorld.Y, speedX, speedY, mod.ProjectileType("rot"), damage, knockBack, player.whoAmI);
            
            
            return false;

              
		}
        
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.VileMushroom, 7);
			recipe.AddIngredient(null, "vile_core", 14);
			recipe.AddIngredient(null, "purity_shard", 12);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}