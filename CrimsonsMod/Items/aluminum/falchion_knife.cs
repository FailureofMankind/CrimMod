using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.aluminum
{
	public class falchion_knife : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Falchion Knife");
			Tooltip.SetDefault("'Straight outta the desert....'\nRight click to thrust the knife for higher damage");
		}
		public override void SetDefaults()
		{
			item.damage = 9;
			item.melee = true;
			item.width = 50;
			item.height = 56;
			item.scale = 0.6f;
			item.useTime = 13;
			item.useAnimation = 13;
			item.useStyle = 1;
			item.knockBack = 2;
            item.value = Item.sellPrice(0, 0, 80, 0);
			item.rare = 1;
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
				item.damage = 16;			
                item.useTime = 8;
                item.useAnimation = 8;
			    item.useStyle = 3;                
			}
            if (player.altFunctionUse != 2)    
			{
				item.damage = 10;							
				item.useTime = 16;
				item.useAnimation = 16;
			    item.useStyle = 1;                                
			}
            return base.CanUseItem(player);


        }	
        
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "aluminum_bar", 15);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        	
	}
}
