using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.purity_wood
{
	public class woodcutter : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Woodcutter");
			Tooltip.SetDefault("Left click to use the axe for lumber\nRight click to throw the axe - Only one may exist at a time");
		}
		public override void SetDefaults()
		{
			item.damage = 14;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 1;
			item.knockBack = 5;
            item.value = Item.sellPrice(0, 0, 0, 5);
			item.rare = 1;
			item.UseSound = SoundID.Item1;
            item.autoReuse = true;            
			item.shootSpeed = 15f;

		}
 
        public override bool AltFunctionUse(Player player)
        {
            return true;
        }
 
        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)     //2 is right click
            {
                item.noMelee = true;
                item.noUseGraphic = true;
                item.useTime = 30;
                item.useAnimation = 30;
				item.shoot = mod.ProjectileType("woodcutterProj");    
                item.axe = 0;
			}
            if (player.altFunctionUse != 2  && player.ownedProjectileCounts[item.shoot] < 1)    
			{
                item.noMelee = false;
                item.noUseGraphic = false;
				item.useTime = 10;
				item.useAnimation = 30;
				item.shoot = 0;
                item.axe = 10;
			}
            return base.CanUseItem(player) && player.ownedProjectileCounts[item.shoot] < 1;


        }	


		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 25);
            recipe.AddIngredient(null, "purity_shard", 8);
			recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}

	}
}
