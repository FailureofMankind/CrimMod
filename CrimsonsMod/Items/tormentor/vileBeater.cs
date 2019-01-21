using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.tormentor
{
    public class vileBeater : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Vile Beater");
			Tooltip.SetDefault("Uses bile cysts for ammo\nHas a chance to inflict Cursed Inferno");
		}
        public override void SetDefaults()
        {
            item.damage = 6;
            item.noMelee = true;
            item.ranged = true;
            item.width = 36;
            item.height = 26;
            item.useTime = 13;
            item.useAnimation = 13;
            item.useStyle = 5;
            item.shoot = mod.ProjectileType("vileBeater");
            item.useAmmo = mod.ItemType("bileCyst");
            item.knockBack = 2;
            item.value = 100;
            item.rare = 3;
            item.UseSound = SoundID.Item95;
            item.autoReuse = true;
            item.shootSpeed = 10f;
        }
		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DemoniteBar, 15);
            recipe.AddIngredient(null, "bileSac", 10);
			recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
    }
}