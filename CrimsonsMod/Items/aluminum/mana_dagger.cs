using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.aluminum
{
	public class mana_dagger : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Steel Dagger");
			Tooltip.SetDefault("'But its too op >_<'\n          ---beep beep lettuce (Failure 2018)");
		}
		public override void SetDefaults()
		{
			item.damage = 8;
			item.magic = true;
            item.mana = 7;
			item.width = 22;
			item.height = 36;
			item.useTime = 3;
			item.useAnimation = 3;
			item.noUseGraphic = true;
			item.useStyle = 1;
			item.knockBack = 0;
			item.value = 10000;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 10f;
			item.shoot = mod.ProjectileType ("mana_dagger");

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "aluminum_bar", 12);
            recipe.AddIngredient(ItemID.ManaCrystal);
            recipe.AddTile(TileID.Anvils);  //this is where to craft the item ,WorkBenches = all WorkBenches    Anvils = all anvils , MythrilAnvil = Mythril Anvil and Orichalcum Anvil, Furnaces = all furnaces , DemonAltar = Demon Altar and Crimson Altar , TinkerersWorkbench = Tinkerer's Workbench
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
