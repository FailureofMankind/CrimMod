using CrimsonsMod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.nettlevine
{
	public class theJungleBall : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Jungle Ball");		
			Tooltip.SetDefault("'Flail powered by the heart of the jungle'");
		}

		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.width = 26;
			item.height = 22;
			item.useAnimation = 15;
			item.useTime = 15;
			item.knockBack = 7f;
			item.damage = 24;
			item.rare = 3;

			item.melee = true;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;
            item.autoReuse = true;

			item.UseSound = SoundID.Item1;
            item.value = Item.sellPrice(0, 0, 95, 0);
			item.shoot = mod.ProjectileType("theJungleBallProj");
            item.shootSpeed = 28f;
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
