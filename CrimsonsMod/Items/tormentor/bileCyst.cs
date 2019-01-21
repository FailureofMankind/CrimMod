using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.tormentor
{
	public class bileCyst : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bile Cyst");
			Tooltip.SetDefault("'run em over'\nAmmo for Vile Spitter");
		}
		public override void SetDefaults()
		{
			item.damage = 15;
			item.thrown = true;
			item.width = 26;
			item.height = 26;
			item.useTime = 30;
			item.useAnimation = 30;
            item.noMelee = true;
            item.noUseGraphic = true;
			item.useStyle = 1;
			item.knockBack = 3;
            item.value = Item.sellPrice(0, 0, 0, 1);
			item.rare = 3;
			item.UseSound = SoundID.Item1;
            item.autoReuse = false;   
			item.shootSpeed = 9f;
            item.shoot = mod.ProjectileType("bileCyst");
            item.consumable = true;
            item.ammo = item.type;
            item.maxStack = 999;

		}

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "bileSac", 2);
            recipe.AddTile(TileID.WorkBenches);  //this is where to craft the item ,WorkBenches = all WorkBenches    Anvils = all anvils , MythrilAnvil = Mythril Anvil and Orichalcum Anvil, Furnaces = all furnaces , DemonAltar = Demon Altar and Crimson Altar , TinkerersWorkbench = Tinkerer's Workbench
			recipe.SetResult(this, 500);
			recipe.AddRecipe();
		}
        



    }
}
