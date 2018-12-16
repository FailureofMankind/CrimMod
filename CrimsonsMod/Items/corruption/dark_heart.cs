using CrimsonsMod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.corruption
{
	public class dark_heart : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dark Heart");
			Tooltip.SetDefault("'Spawn of the creepy-crawlies'");

			// These are all related to gamepad controls and don't seem to affect anything else
			ItemID.Sets.Yoyo[item.type] = true;
			ItemID.Sets.GamepadExtraRange[item.type] = 15;
			ItemID.Sets.GamepadSmartQuickReach[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.useStyle = 6;
			item.width = 42;
			item.height = 42;
			item.useAnimation = 5;
			item.useTime = 5;
			item.shootSpeed = 10f;
			item.knockBack = 4f;
			item.damage = 10;
			item.rare = 2;

			item.melee = true;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;

			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(0, 0, 10, 0);
			item.shoot = mod.ProjectileType("dark_heart_proj");
		}

		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "vile_core", 12);
            recipe.AddIngredient(3278);
            recipe.AddIngredient(null, "purity_shard", 5);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}


