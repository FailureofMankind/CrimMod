using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.purity_wood
{
    public class bark_pelter : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bark Pelter");
			Tooltip.SetDefault("Uses bark as ammo\n'Yeet it over here, yes...'");
		}

        public override void SetDefaults()
        {
            item.damage = 10;
            item.noMelee = true;
            item.ranged = true;
            item.width = 36;
            item.height = 26;
            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = 5;
            item.shoot = mod.ProjectileType("barkProj");
            item.useAmmo = mod.ItemType("bark");
            item.knockBack = 1;
            item.value = 100;
            item.rare = 1;
            item.UseSound = SoundID.Item98;
            item.autoReuse = true;
            item.shootSpeed = 24f;

        }
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-5, 0);
		}       

		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 20);
            recipe.AddIngredient(null, "purity_shard", 5);
			recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
    }
}