using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons.shortswords
{
	public class icicle : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Icicle");
			Tooltip.SetDefault("'bEst'\nInflicts frostburn");
		}
		public override void SetDefaults()
		{
			item.damage = 21;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.scale = 0.6f;
			item.useTime = 40;
			item.useAnimation = 40;
            item.useTurn = true;
			item.useStyle = 3;
			item.knockBack = 5;
            item.value = Item.sellPrice(0, 0, 10, 0);
			item.rare = 1;
			item.UseSound = SoundID.Item1;
            item.autoReuse = true;            

		}
        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {        
			target.AddBuff(44, 600); //buff id frostburn
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IceBlock, 16);
            recipe.AddIngredient(ItemID.SnowBlock, 50);
			recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	
	
	}
}
