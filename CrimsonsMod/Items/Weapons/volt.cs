using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons
{
	public class volt : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Volt Smasher");
			Tooltip.SetDefault("'But its sand.....'\nRight click to stab");
		}
		public override void SetDefaults()
		{
			item.damage = 45;
			item.melee = true;
			item.width = 58;
			item.height = 58;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 4;
            item.value = Item.sellPrice(0, 12, 0, 0);
			item.rare = 5;
			item.UseSound = SoundID.Item1;
            item.autoReuse = true;            
			item.shootSpeed = 10f;

		}
 
        public override bool AltFunctionUse(Player player)
        {
            return true;
        }
 
        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)     //2 is right click
            {
 
                item.useTime = 13;
                item.useAnimation = 13;
			    item.useStyle = 3;                
				item.shoot = 0;                
			}
            if (player.altFunctionUse != 2)    
			{
				item.useTime = 15;
				item.useAnimation = 15;
			    item.useStyle = 1;                                
				item.shoot = mod.ProjectileType("volt");
			}
            return base.CanUseItem(player);


        }		
	}
}
