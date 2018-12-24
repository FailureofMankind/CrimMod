using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.tideStrider
{
    public class waterTome : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Water Tome");
			Tooltip.SetDefault("Cast a semi-piercing water bolt");
		}

        public override void SetDefaults()
        {
            item.damage = 14;
            item.noMelee = true;
            item.magic = true;
            item.mana = 3;
            item.width = 28;
            item.height = 30;
            item.useTime = 24;
            item.useAnimation = 24;
            item.useStyle = 5;
            item.knockBack = 0;
            item.value = Item.sellPrice(0, 0,90, 0);
            item.rare = 1;
            item.UseSound = SoundID.Item8;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("waterNonBouncingBolt");
            item.shootSpeed = 5f;
        }
		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "tideScale", 10);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
    }
}