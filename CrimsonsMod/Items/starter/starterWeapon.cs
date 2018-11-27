using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.starter
{
	public class starterWeapon : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Beginner Sword");
			Tooltip.SetDefault("'Is it me or is this actually broken?'\nRight click to stab");
		}
		public override void SetDefaults()
		{
			item.damage = 8;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useTurn = true;
			item.useStyle = 1;
			item.knockBack = 3;
            item.value = Item.sellPrice(0, 0, 0, 10);
			item.rare = 0;
			item.UseSound = SoundID.Item1;
            item.autoReuse = true;            

		}


        public override bool AltFunctionUse(Player player)
        {
            return true;
        }
 
        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)     //2 is right click
            {
 			    item.useStyle = 3;                
			}
            if (player.altFunctionUse != 2)    
			{
			    item.useStyle = 1;                                
			}
            return base.CanUseItem(player);


        }		
	}
}
