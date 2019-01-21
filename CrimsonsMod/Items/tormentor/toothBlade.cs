using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.tormentor
{
	public class toothBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tooth Blade");
			Tooltip.SetDefault("Right click to throw");
		}
		public override void SetDefaults()
		{
			item.damage = 18;
			item.melee = true;
			item.width = 46;
			item.height = 4;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 1;
			item.knockBack = 5;
            item.value = Item.sellPrice(0, 0, 0, 10);
            item.useTurn = true;
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
                item.noMelee = true;
                item.noUseGraphic = true;
				item.shootSpeed = 10f;
				item.shoot = mod.ProjectileType("toothBladeProj");    
			}
            if (player.altFunctionUse != 2  && player.ownedProjectileCounts[item.shoot] < 1)    
			{
                item.noMelee = false;
                item.noUseGraphic = false;
				item.shoot = 0;
			}
            return base.CanUseItem(player) && player.ownedProjectileCounts[item.shoot] < 1;
        }
		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DemoniteBar, 15);
            recipe.AddIngredient(null, "bileSac", 10);
			recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}