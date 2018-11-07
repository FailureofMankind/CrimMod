using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons
{
	public class orichalcum_kunai : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Orichalcum Kunai");
			Tooltip.SetDefault("Sticks to enemies and bursts into petals");
		}
		public override void SetDefaults()
		{
			item.damage = 35;
			item.thrown = true;
			item.width = 14;
			item.height = 36;
			item.useTime = 19;
			item.useAnimation = 19;
			item.noUseGraphic = true;
			item.useStyle = 1;
			item.noMelee = true;
			item.knockBack = 2;
			item.value = 10000;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 15f;
			item.shoot = mod.ProjectileType ("orichalcum_kunai");
            item.consumable = true;
            item.maxStack = 999;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MythrilBar);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 100);
			recipe.AddRecipe();
		}
	}
}
