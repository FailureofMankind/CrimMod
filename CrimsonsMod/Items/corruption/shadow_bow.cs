using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.corruption
{
    public class shadow_bow : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shadow Bow");
			Tooltip.SetDefault("'is shadow an object?'\nConverts wooden arows to unholy arrows");
		}

        public override void SetDefaults()
        {
            item.damage = 9;
            item.noMelee = true;
            item.ranged = true;
            item.width = 30;
            item.height = 50;
            item.useTime = 35;
            item.useAnimation = 35;
            item.useStyle = 5;
            item.shoot = 12;
            item.useAmmo = AmmoID.Arrow;
            item.knockBack = 1;
            item.value = Item.sellPrice(0, 0, 10, 0);
            item.rare = 2;
            item.UseSound = SoundID.Item5;
            item.autoReuse = true;
            item.shootSpeed = 10f;

        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if(type == 1)
            {
                type = 4;
            }
            return true;
        }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.VileMushroom, 7);
			recipe.AddIngredient(null, "vile_core", 14);
			recipe.AddIngredient(null, "purity_shard", 12);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

    }
}