using CrimsonsMod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.ferrium
{
	public class Ember : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Embers");
			Tooltip.SetDefault("'A burning sensation'\nReleases damaging embers when hit");

			// These are all related to gamepad controls and don't seem to affect anything else
			ItemID.Sets.Yoyo[item.type] = true;
			ItemID.Sets.GamepadExtraRange[item.type] = 15;
			ItemID.Sets.GamepadSmartQuickReach[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.width = 24;
			item.height = 24;

			item.useAnimation = 25;
			item.useTime = 25;

			item.shootSpeed = 16f;
			item.shoot = mod.ProjectileType("EmberProj");
			item.knockBack = 2.5f;
			item.damage = 18;
			item.rare = 4;

			item.melee = true;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.UseSound = SoundID.Item1;
			item.value = 1000;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HellstoneBar,9);
			recipe.AddIngredient(null, "ferrium_plating", 6);
			recipe.AddIngredient(ItemID.Cobweb, 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
