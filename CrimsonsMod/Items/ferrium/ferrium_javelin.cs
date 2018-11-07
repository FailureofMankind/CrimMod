using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.ferrium
{
	public class ferrium_javelin : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ferrium Javelins");
			Tooltip.SetDefault("Ignites into infernal explosion after hitting enemy");
		}
		public override void SetDefaults()
		{
			item.damage = 18;
			item.thrown = true;
			item.width = 52;
			item.height = 52;
			item.useTime = 25;
			item.useAnimation = 25;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.useStyle = 1;
			item.knockBack = 0;
			item.value = 100;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 8f;
			item.shoot = mod.ProjectileType ("ferrium_javelin");
            item.consumable = true;
            item.maxStack = 999;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HellstoneBar, 1);
            recipe.AddIngredient(null, "ferrium_plating", 2);
            recipe.AddTile(TileID.Anvils);  //this is where to craft the item ,WorkBenches = all WorkBenches    Anvils = all anvils , MythrilAnvil = Mythril Anvil and Orichalcum Anvil, Furnaces = all furnaces , DemonAltar = Demon Altar and Crimson Altar , TinkerersWorkbench = Tinkerer's Workbench
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}
