using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.nettlevine
{
    public class leafpeater : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Leafpeater");
			Tooltip.SetDefault("A fast pulse repeater that has 33% chance to not consume arrow");
		}
        public override void SetDefaults()
        {
            item.damage = 13;
            item.noMelee = true;
            item.ranged = true;
            item.width = 28;
            item.height = 40;
            item.useTime = 11;
            item.useAnimation = 11;
            item.useStyle = 5;
            item.shoot = 3;
            item.useAmmo = AmmoID.Arrow;
            item.knockBack = 0;
            item.value = Item.sellPrice(0, 0, 95, 0);
            item.rare = 3;
            item.UseSound = SoundID.Item5;
            item.autoReuse = true;
            item.shootSpeed = 13f;
        }
        public override bool ConsumeAmmo(Player player)
        {
            return Main.rand.NextFloat() >= .33f;
        }           
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.JungleSpores, 5);
			recipe.AddIngredient(null, "poisonVine", 10);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}