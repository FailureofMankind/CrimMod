using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.manganese
{
	public class anhydrous_stars : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Anhydrous Stars");
			Tooltip.SetDefault("'The air around the stars are goes dry...'");

		}
		public override void SetDefaults()
		{
			item.damage = 11;
			item.thrown = true;
			item.width = 22;
			item.height = 22;
			item.useTime = 22;
			item.useAnimation = 22;
            item.noMelee = true;
			item.noUseGraphic = true;
			item.useStyle = 1;
			item.knockBack = 0;
			item.value = 100;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 12f;
			item.shoot = mod.ProjectileType ("anhydrous_stars");
            item.consumable = true;
            item.maxStack = 999;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "manganese_bar", 10);
            recipe.AddIngredient(null, "DryScales", 1);
            recipe.AddTile(TileID.Anvils);  //this is where to craft the item ,WorkBenches = all WorkBenches    Anvils = all anvils , MythrilAnvil = Mythril Anvil and Orichalcum Anvil, Furnaces = all furnaces , DemonAltar = Demon Altar and Crimson Altar , TinkerersWorkbench = Tinkerer's Workbench
			recipe.SetResult(this, 500);
			recipe.AddRecipe();
		}
	}
}
