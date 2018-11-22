using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.purity_wood
{
    public class leaf_shot : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Leaf Shot");
			Tooltip.SetDefault("Converts wooden arrows into magic leaves");
		}

        public override void SetDefaults()
        {
            item.damage = 6;
            item.noMelee = true;
            item.ranged = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 26;
            item.useAnimation = 26;
            item.useStyle = 5;
            item.shoot = 12;
            item.useAmmo = AmmoID.Arrow;
            item.knockBack = 0;
            item.value = Item.sellPrice(0, 0, 0, 10);
            item.rare = 1;
            item.UseSound = SoundID.Item5;
            item.autoReuse = true;
            item.shootSpeed = 10f;

        }

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
          {
            if(type == 1)
                {
                    int a = Projectile.NewProjectile(position.X, position.Y, speedX, speedY, 227, damage, 3, player.whoAmI, 0f, 0f);
                    Main.projectile[a].tileCollide = true;
                    Main.projectile[a].ranged = true;
                    
                    return false;
                }
                else
                {
                    return true;
                }
          }
		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 15);
            recipe.AddIngredient(null, "purity_shard", 7);
			recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}

    }
}