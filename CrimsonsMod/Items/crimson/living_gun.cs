using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.crimson
{
    public class living_gun : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Living Gun");
			Tooltip.SetDefault("'...it tries to lick your face...'\nConverts muskets into exploding blood bullets");
		}

        public override void SetDefaults()
        {
            item.damage = 14;
            item.noMelee = true;
            item.ranged = true;
            item.width = 64;
            item.height = 42;
            item.scale = 0.7f;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 5;
            item.shoot = 10;
            item.useAmmo = AmmoID.Bullet;
            item.knockBack = 3;
            item.value = Item.sellPrice(0, 0, 95, 0);
            item.rare = 2;
            item.UseSound = SoundID.NPCHit25;
            item.autoReuse = false;
            item.shootSpeed = 14f;

        }
		
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
        if(type == 14)
            {
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("living_gun"), damage, knockBack, player.whoAmI, 0f, 0f);
                return false;
            }
            else
            {
                return true;
            }
        }

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-3, 0);
		}          
          

        public override void AddRecipes()
        
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "parasitic_organ", 14);
            recipe.AddIngredient(ItemID.Shadewood, 25);
            recipe.AddIngredient(null, "purity_shard", 10);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}