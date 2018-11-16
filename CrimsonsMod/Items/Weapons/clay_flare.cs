using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons
{
    public class clay_flare : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Clay Flare");
		}

        public override void SetDefaults()
        {
            item.damage = 12;
            item.noMelee = true;
            item.ranged = true;
            item.width = 40;
            item.height = 26;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 5;
            item.shoot = 10;
            item.useAmmo = AmmoID.Bullet;
            item.knockBack = 3;
            item.value = Item.sellPrice(0, 0, 30, 0);
            item.rare = 0;
            item.UseSound = SoundID.Item41;
            item.autoReuse = false;
            item.shootSpeed = 3f;

        }


		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-3, 0);
		}          
          

        public override void AddRecipes()
        
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ClayBlock, 24);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}