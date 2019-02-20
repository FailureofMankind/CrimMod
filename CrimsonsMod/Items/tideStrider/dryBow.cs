using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.tideStrider
{
    public class dryBow : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dry Bow");
			Tooltip.SetDefault("Has a chance to shoot a dry arrow");
		}

        public override void SetDefaults()
        {
            item.damage = 10;
            item.noMelee = true;
            item.ranged = true;
            item.width = 28;
            item.height = 40;
            item.useTime = 19;
            item.useAnimation = 19;
            item.useStyle = 5;
            item.shoot = 3;
            item.useAmmo = AmmoID.Arrow;
            item.knockBack = 0;
            item.value = Item.sellPrice(0, 0, 95, 0);
            item.rare = 1;
            item.UseSound = SoundID.Item75;
            item.autoReuse = true;
            item.shootSpeed = 8f;

        }

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
          {
            if(Main.rand.Next(2) == 0)
                {
                    Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("dryArrow"), damage, 0, player.whoAmI, 0f, 0f);
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
            recipe.AddIngredient(null, "tideScale", 7);
            recipe.AddTile(TileID.Anvils);  //this is where to craft the item ,WorkBenches = all WorkBenches    Anvils = all anvils , MythrilAnvil = Mythril Anvil and Orichalcum Anvil, Furnaces = all furnaces , DemonAltar = Demon Altar and Crimson Altar , TinkerersWorkbench = Tinkerer's Workbench
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

    }
}