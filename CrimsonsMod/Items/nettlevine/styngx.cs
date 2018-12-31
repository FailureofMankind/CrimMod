using CrimsonsMod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.nettlevine
{
	public class styngx : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Styngx");		
			Tooltip.SetDefault("Shoots stingers at nearby enemies");

			// These are all related to gamepad controls and don't seem to affect anything else
			ItemID.Sets.Yoyo[item.type] = true;
			ItemID.Sets.GamepadExtraRange[item.type] = 15;
			ItemID.Sets.GamepadSmartQuickReach[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.width = 26;
			item.height = 22;
			item.useAnimation = 15;
			item.useTime = 15;
			item.shootSpeed = 16f;
			item.knockBack = 3f;
			item.damage = 14;
			item.rare = 3;

			item.melee = true;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;

			item.UseSound = SoundID.Item1;
            item.value = Item.sellPrice(0, 0, 95, 0);
			item.shoot = mod.ProjectileType("styngxProj");
		}
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.JungleSpores, 5);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}
