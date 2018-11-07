using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons.shortswords
{
	public class minisama : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Minisama");
			Tooltip.SetDefault("'Deadly as its older brother'\nEnemies hit by this blade will get gouged with water");
		}
		public override void SetDefaults()
		{
			item.damage = 46;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 13;
			item.useAnimation = 13;
            item.useTurn = true;
			item.useStyle = 3;
			item.knockBack = 5;
            item.value = Item.sellPrice(0, 1, 0, 0);
			item.rare = 4;
			item.UseSound = SoundID.Item1;
            item.autoReuse = true;            

		}
        
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            Projectile.NewProjectile(player.position.X, (int)(player.position.Y + 40), -5, -4, 22, damage, knockback, player.whoAmI, 0f, 0f);
            Projectile.NewProjectile(player.position.X, (int)(player.position.Y + 40), 5, -4, 22, damage, knockback, player.whoAmI, 0f, 0f);
        //projectile id aqua stream
		}

		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Spike, 5);
            recipe.AddIngredient(null, "rune_stone", 65);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	
	
	
	}
}
