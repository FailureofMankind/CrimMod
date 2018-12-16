using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.geode
{
	public class crystal_breaker : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crystal Breaker");	
			Tooltip.SetDefault("Enemies are hailed with crystals");
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults()
		{
			item.damage = 55;
			item.melee = true;
			item.width = 60;
			item.height = 60;
            item.scale = 1.6f;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 1;
			item.knockBack = 7;
			item.value = 10;
			item.rare = 6;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.useTurn = true;
		}
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            for(int i = 0; i < 9; i++)
            {
                int a = Projectile.NewProjectile(target.Center.X, (int)(target.Center.Y - 500), Main.rand.Next(-5, 5), Main.rand.Next(10, 40), 94, damage, knockback, player.whoAmI, 0f, 0f);
                Main.projectile[a].magic = false;
                Main.projectile[a].melee = true;

                int xplody_boi = Dust.NewDust(target.Center, 0, 0, 176);
                Main.dust[xplody_boi].velocity *= 4f;
                Main.dust[xplody_boi].scale *= 3f;
                Main.PlaySound(SoundID.NPCHit5, target.Center);        
            }
        }		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofMight, 5);
            recipe.AddIngredient(null, "crystal_geode", 20);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}