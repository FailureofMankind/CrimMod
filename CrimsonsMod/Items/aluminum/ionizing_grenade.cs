using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.aluminum
{
	public class ionizing_grenade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ionizing Grenade");
			Tooltip.SetDefault("Explodes into an high-energy sphere");
		}
		public override void SetDefaults()
		{
			item.damage = 15;
			item.thrown = true;
			item.width = 16;
			item.height = 16;
			item.scale = 0.6f;
			item.useTime = 80;
			item.useAnimation = 80;
			item.useStyle = 1;
			item.knockBack = 3;
            item.value = Item.sellPrice(0, 0, 1, 0);
			item.rare = 1;
			item.UseSound = SoundID.Item1;
            item.autoReuse = false;   
			item.shootSpeed = 9f;
            item.shoot = mod.ProjectileType("ionizing_grenade");
            item.consumable = true;
            item.maxStack = 99;

		}

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "aluminum_bar", 2);
            //recipe.AddIngredient(null, "ionic_cells", 10);
            //recipe.AddIngredient(null, "silver_dust", 5);
            recipe.AddTile(TileID.Anvils);  //this is where to craft the item ,WorkBenches = all WorkBenches    Anvils = all anvils , MythrilAnvil = Mythril Anvil and Orichalcum Anvil, Furnaces = all furnaces , DemonAltar = Demon Altar and Crimson Altar , TinkerersWorkbench = Tinkerer's Workbench
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
        



    }
}
