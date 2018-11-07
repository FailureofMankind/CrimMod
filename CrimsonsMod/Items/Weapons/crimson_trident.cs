using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons
{
    public class crimson_trident : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crimson's Trident: Melee");
			Tooltip.SetDefault("'Inundated with Crimson's essence'\nWarning: too op");
		}

        public override void SetDefaults()
        {
            item.damage = 100;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 50;
            item.useAnimation = 50;
            item.knockBack = 7;
            item.UseSound = SoundID.Item1;
            item.noMelee = true;
            item.noUseGraphic = true;
            item.useTurn = true;
            item.useStyle = 5;
            item.value = Item.sellPrice(0, 30, 0, 0);
            item.rare = 11;
            item.expert = true;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("crimson_trident_spear");
            item.shootSpeed = 20f;            
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("crimson_proj"), damage, knockBack, player.whoAmI, 0f, 0f);
            
            return true;
        }
        
        
        public override bool CanUseItem(Player player)
        {
            return player.ownedProjectileCounts[item.shoot] < 1;
        }

        
    }
}