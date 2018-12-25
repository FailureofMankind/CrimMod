using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.fungus
{
    public class mushroomTome : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mushroom Tome");
			Tooltip.SetDefault("Cast a mushroom spore that explodes into homing mold particles");
		}

        public override void SetDefaults()
        {
            item.damage = 10;
            item.noMelee = true;
            item.magic = true;
            item.mana = 10;
            item.width = 28;
            item.height = 30;
            item.useTime = 45;
            item.useAnimation = 45;
            item.useStyle = 5;
            item.knockBack = 0;
            item.value = Item.sellPrice(0, 0, 90, 0);
            item.rare = 1;
            item.UseSound = SoundID.Item8;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("mushroomSpore");
            item.shootSpeed = 10f;
        }
		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GlowingMushroom, 11);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
    }
}