using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons.shortswords
{
	public class blazing_stabber : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blazing Stabber");
			Tooltip.SetDefault("'Warning! can cause 4th degree burns'\nInflicts OnFire debuff and stabbing enemies will spark fireballs");
		}
		public override void SetDefaults()
		{
			item.damage = 24;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 3;
            item.useTurn = true;
			item.knockBack = 2;
            item.value = Item.sellPrice(0, 2, 0, 0);
			item.rare = 4;
			item.UseSound = SoundID.Item1;
            item.autoReuse = true;            

		}

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            Projectile.NewProjectile(target.Center.X, (int)(target.position.Y - 60), -2, -1, 15, damage, knockback, player.whoAmI, 0f, 0f);
            Projectile.NewProjectile(target.Center.X, (int)(target.position.Y - 60), 2, -1, 15, damage, knockback, player.whoAmI, 0f, 0f);
        
			target.AddBuff(24, 600); //buff id onfire
		}
		
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HellstoneBar, 13);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
 

	}

}
