using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons
{
	public class transcended : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Transcended");	
			Tooltip.SetDefault("'Play the music of the skies'");
		}

		public override void SetDefaults()
		{
			item.damage = 18;
			item.magic = true;
			item.mana = 9;
			item.width = 64;
			item.height = 64;
			item.useTime = 21;
			item.useAnimation = 21;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 3;
            item.value = Item.sellPrice(0, 2, 15, 0);
			item.rare = 3;
			item.UseSound = SoundID.Item26;
			item.autoReuse = true;
			item.shoot = 76;
			item.shootSpeed = 10f;
		}
		
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int rand = Main.rand.Next(2);
            if(rand == 0)
            {
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, 77, damage, knockBack, player.whoAmI, 0f, 0f);
            }
            if(rand == 1)
            {
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, 78, damage, knockBack, player.whoAmI, 0f, 0f);
            }
            if(rand == 2)
            {
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage, knockBack, player.whoAmI, 0f, 0f);
            }
            return false;
        }		
		
	}
}