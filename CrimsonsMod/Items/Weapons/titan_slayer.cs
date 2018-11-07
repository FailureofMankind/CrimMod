using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons
{
    public class titan_slayer : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Titan Slayer");
			Tooltip.SetDefault("Shoots special projectile depending on vanilla arrows");
		}

        public override void SetDefaults()
        {
            item.damage = 56;
            item.noMelee = true;
            item.ranged = true;
            item.width = 30;
            item.height = 42;
            item.useTime = 13;
            item.useAnimation = 13;
            item.useStyle = 5;
            item.shoot = 12;
            item.useAmmo = AmmoID.Arrow;
            item.knockBack = 2;
            item.value = Item.sellPrice(0, 34, 0, 0);
            item.rare = 8;
            item.UseSound = SoundID.DD2_SkyDragonsFuryShot;
            item.autoReuse = true;
            item.shootSpeed = 19f;

        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if (type == ProjectileID.UnholyArrow) 
			{
				type = mod.ProjectileType("unholy_proj");
			}
			if (type == ProjectileID.FrostburnArrow)
			{
				type = mod.ProjectileType("frost_proj");
			}
			if (type == ProjectileID.BoneArrow)
			{
				type = mod.ProjectileType("bone_proj");
			}
			if (type == 5) // jester arrow
			{
				type = mod.ProjectileType("jester_proj");
			}
			if (type == ProjectileID.HolyArrow)
			{
				type = mod.ProjectileType("holy_proj");
			}
			if (type == ProjectileID.CursedArrow) 
			{
				type = mod.ProjectileType("cursed_proj");
			}
			if (type == ProjectileID.IchorArrow) 
			{
				type = mod.ProjectileType("ichor_proj");
			}
			if (type == ProjectileID.HellfireArrow) 
			{
				type = 485;
			}
			if (type == ProjectileID.VenomArrow) 
			{
				type = mod.ProjectileType("venom_proj");
			}
			if (type == 639) //luminite arrow
			{
				type = mod.ProjectileType("luminite_proj");
			}
            
            
            return true; // return true to allow tmodloader to call Projectile.NewProjectile as normal
		
        
        
        }




		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-5, 0);
		}          
    
    
    }
}