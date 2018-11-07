using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons.shortswords
{
	public class feral_knife : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Feral Knife");
			Tooltip.SetDefault("'Why does this look like calamity's leaf shortsword? Because both of them are lazy'\nRelease spores on hit");
		}
		public override void SetDefaults()
		{
			item.damage = 22;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 23;
			item.useAnimation = 23;
            item.useTurn = true;
			item.useStyle = 3;
			item.knockBack = 2;
            item.value = Item.sellPrice(0, 1, 0, 0);
			item.rare = 3;
			item.UseSound = SoundID.Item1;
            item.autoReuse = true;            

		}
        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            Projectile.NewProjectile(player.position.X, (int)(player.position.Y + 40), 4, 0, 228, damage, knockback, player.whoAmI, 0f, 0f);
            Projectile.NewProjectile(player.position.X, (int)(player.position.Y + 40), 0, -4, 228, damage, knockback, player.whoAmI, 0f, 0f);
            Projectile.NewProjectile(player.position.X, (int)(player.position.Y + 40), -4, 0, 228, damage, knockback, player.whoAmI, 0f, 0f);
            Projectile.NewProjectile(player.position.X, (int)(player.position.Y + 40), 0, 4, 228, damage, knockback, player.whoAmI, 0f, 0f);
            
			Projectile.NewProjectile(player.position.X, (int)(player.position.Y + 40), 3, 3, 228, damage, knockback, player.whoAmI, 0f, 0f);
            Projectile.NewProjectile(player.position.X, (int)(player.position.Y + 40), 3, -3, 228, damage, knockback, player.whoAmI, 0f, 0f);
            Projectile.NewProjectile(player.position.X, (int)(player.position.Y + 40), -3, 3, 228, damage, knockback, player.whoAmI, 0f, 0f);
            Projectile.NewProjectile(player.position.X, (int)(player.position.Y + 40), -3, -3, 228, damage, knockback, player.whoAmI, 0f, 0f);
        
			target.AddBuff(20, 600); //buff id onfire
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.JungleSpores, 24);
            recipe.AddIngredient(ItemID.Vine, 12);
			recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }




	}
}
