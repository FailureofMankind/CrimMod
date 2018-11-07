using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons.shortswords
{
	public class terra_dagger : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Terra Dagger");
			Tooltip.SetDefault("'the power of Terraria joins you to vaporise your foes'\nHitting with the blade inflicts several debuffs");
		}
		public override void SetDefaults()
		{
			item.damage = 40;
			item.melee = true;
			item.width = 58;
			item.height = 58;
			item.useTime = 4;
			item.useAnimation = 4;
			item.useStyle = 3;
			item.knockBack = 5;
            item.value = Item.sellPrice(0, 12, 0, 0);
			item.rare = 7;
			item.UseSound = SoundID.Item1;
            item.autoReuse = true;            
			item.shootSpeed = 10f;
			item.shoot = 132;
	    }
        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
			target.AddBuff(20, 800); //buff id poisoned
			target.AddBuff(24, 800); //buff id onfire
			target.AddBuff(39, 800); //buff id cursed inferno
			target.AddBuff(44, 800); //buff id frostburn
			target.AddBuff(69, 1200); //buff id ichor
			target.AddBuff(31, 300); //buff id confused
		}
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
			int a = Projectile.NewProjectile(position.X, position.Y, speedX, speedY, 132, damage, 0, player.whoAmI);
			Main.projectile[a].penetrate = 1; //im basically calling the stats and channging penetration of the clone projectile
			Main.projectile[a].timeLeft = 15; //im basically calling the stats and channging time of the clone projectile
              
            return false;
		}
	
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "elemental_dagger");
            recipe.AddIngredient(ItemID.BrokenHeroSword);
			recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	
	
	
	}
}
