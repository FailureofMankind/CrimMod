using CrimsonsMod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons.scythes
{
	public class splash : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Typhoon Splash");
			Tooltip.SetDefault("'aaa.. bubbles?'");
		}

		public override void SetDefaults()
		{
            item.melee = true;
            item.damage = 120;
			item.useTime = 10;   //How fast the Weapon is used.
            item.useAnimation = 10;     //How long the Weapon is used for.
            item.channel = true;
            item.useStyle = 100;    //The way your Weapon will be used, 1 is the regular sword swing for example
            item.knockBack = 13f;    //The knockback stat of your Weapon.
            item.value = Item.buyPrice(0, 10, 0, 0); // How much the item is worth, in copper coins, when you sell it to a merchant. It costs 1/5th of this to buy it back from them. An easy way to remember the value is platinum, gold, silver, copper or PPGGSSCC (so this item price is 10gold)
            item.rare = 9;   //The color the title of your Weapon when hovering over it ingame                    
            item.shootSpeed = 1;
            item.useTurn = true;
            item.shoot = mod.ProjectileType("splash");  //This defines what type of projectile this weapon will shoot  
            item.noUseGraphic = true; // this defines if it does not use graphic
            item.noMelee = true;
		}

        public override bool UseItemFrame(Player player)     //this defines what frame the player use when this weapon is used
        {
            player.bodyFrame.Y = 3 * player.bodyFrame.Height;
            return true;
        }


	}
}
