using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.fungus
{
    public class mushroomWand : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mushroom Wand");
			Tooltip.SetDefault("'shrooms hehe...'");
            Item.staff[item.type] = true;
		}

        public override void SetDefaults()
        {
            item.damage = 19;
            item.noMelee = true;
            item.magic = true;
            item.mana = 4;
            item.width = 28;
            item.height = 30;
            item.useTime = 21;
            item.useAnimation = 21;
            item.useStyle = 5;
            item.knockBack = 0;
            item.value = Item.sellPrice(0, 0, 90, 0);
            item.rare = 1;
            item.UseSound = SoundID.Item8;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("mushroomBolt");
            item.shootSpeed = 5f;
        }
		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GlowingMushroom, 11);
			recipe.AddIngredient(mod.ItemType("bloodTear"), 2);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
    }
}