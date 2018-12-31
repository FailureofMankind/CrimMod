using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.nettlevine
{
    public class nettleBow : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nettle Bow");
			Tooltip.SetDefault("'the ancient lihzardian's choice of weapon'\nConverts wooden arrows into chlorophyte arrows");
		}
        public override void SetDefaults()
        {
            item.damage = 25;
            item.noMelee = true;
            item.ranged = true;
            item.width = 22;
            item.height = 40;
            item.useTime = 24;
            item.useAnimation = 24;
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
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if (type == ProjectileID.WoodenArrowFriendly)
			{
				type = 225;
			}
			return true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.JungleSpores, 5);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}