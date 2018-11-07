using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons.swords
{
	public class Halo : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Halo");
			Tooltip.SetDefault("It shines brilliantly... not really\nInflicts midas on enemy hits");
		}
		public override void SetDefaults()
		{
			item.damage = 6;
			item.melee = true;
			item.width = 58;
			item.height = 58;
			item.useTime = 9;
			item.useAnimation = 9;
			item.useStyle = 3;
			item.knockBack = 4;
            item.value = Item.sellPrice(0, 0, 45, 0);
			item.rare = 2;
			item.useTurn = true;
			item.UseSound = SoundID.Item1;
            item.autoReuse = true;            

		}
 
        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
			target.AddBuff(72, 6000); //buff id midas (enemies drop more gold)


		}
		
		
		
		
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "wooden_shortsword");
            recipe.AddIngredient(null, "manganese_bar", 10);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}
