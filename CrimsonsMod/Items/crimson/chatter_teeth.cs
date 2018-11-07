using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.crimson
{
    public class chatter_teeth : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chatter Teeth");
			Tooltip.SetDefault("'I have no idea how this works!'\nShoots a volley of 2 bullets");
		}

        public override void SetDefaults()
        {
            item.damage = 8;
            item.noMelee = true;
            item.ranged = true;
            item.width = 64;
            item.height = 40;
            item.scale = 0.7f;
            item.useTime = 3;
            item.useAnimation = 6;
            item.useStyle = 5;
            item.reuseDelay = 35;
            item.shoot = 10;
            item.useAmmo = AmmoID.Bullet;
            item.knockBack = 0;
            item.value = Item.sellPrice(0, 0, 95, 0);
            item.rare = 2;
            item.UseSound = SoundID.Item31;
            item.autoReuse = true;
            item.shootSpeed = 8f;

        }



		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-3, 0);
		}          
          

        public override void AddRecipes()
        
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "parasitic_organ", 10);
            recipe.AddIngredient(ItemID.Shadewood, 25);
            recipe.AddIngredient(null, "purity_shard", 13);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}