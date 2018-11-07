using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons
{
	public class adamantite_knife : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Adamantite Knives");
			Tooltip.SetDefault("Inflicts 'oiled' debuff which increases DoT damage\nHas high knockback");
		}
		public override void SetDefaults()
		{
			item.damage = 46;
			item.thrown = true;
			item.width = 14;
			item.height = 36;
			item.useTime = 13;
			item.useAnimation = 13;
			item.noUseGraphic = true;
			item.useStyle = 1;
			item.knockBack = 11;
			item.value = 10000;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 5f;
			item.shoot = mod.ProjectileType ("adamantite_knife");
            item.consumable = true;
            item.maxStack = 999;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AdamantiteBar);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this, 55);
			recipe.AddRecipe();
		}
	}
}
