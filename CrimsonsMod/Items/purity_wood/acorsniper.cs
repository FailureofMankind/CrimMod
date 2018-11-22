using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.purity_wood
{
    public class acorsniper : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Acorsniper");
			Tooltip.SetDefault("Uses acorns as ammo\n'Totally nutz!'");
		}

        public override void SetDefaults()
        {
            item.damage = 26;
            item.noMelee = true;
            item.ranged = true;
            item.width = 54;
            item.height = 16;
            item.useTime = 70;
            item.useAnimation = 70;
            item.useStyle = 5;
            item.shoot = mod.ProjectileType("acornProj");
            item.useAmmo = ItemID.Acorn;
            item.knockBack = 6;
            item.value = 1000;
            item.rare = 1;
            item.UseSound = SoundID.Item40;
            item.autoReuse = false;
            item.shootSpeed = 30f;

        }
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-10, 0);
		}       

		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 30);
            recipe.AddIngredient(null, "purity_shard", 15);
			recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
    }
}