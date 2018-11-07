using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons
{
    public class laserthingy : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("laser thingy");
            Tooltip.SetDefault("cast a laser thingy");
        }

        public override void SetDefaults()
        {
            item.damage = 15;//The damage stat for the Weapon.
            item.width = 40;
            item.height = 42;
            item.magic = true;     //This defines if it does Melee damage and if its effected by Melee increasing Armor/Accessories.
            item.useTime = 1;  //How fast the Weapon is used.
            item.useAnimation = 25;   //How long the Weapon is used for.
            item.mana = 3;
            item.value = Item.sellPrice(0, 0, 90, 0);
            item.useStyle = 5;//The way your Weapon will be used, 1 is the regular sword swing for example
            item.knockBack = 4;//The knockback stat of your Weapon.
            item.rare = 1;//The color the title of your Weapon when hovering over it ingame   
            item.autoReuse = true; //This defines what type of projectile this weapon will shot	
            item.shootSpeed = 10f;
            item.noMelee = true;// Makes sure that the animation when using the item doesn't hurt NPCs.
            item.UseSound = SoundID.Item13; //The sound played when using your Weapon
			item.noUseGraphic = true;
			item.shoot = mod.ProjectileType ("laser");
        }
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 1;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30));
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, 440, damage, knockBack, player.whoAmI);
            }
              
            return true;
        }
	}
}