using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons.swords
{
	public class GrayMatter : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Ancient Broadsword");
			Tooltip.SetDefault("'causes rips in time? idk'\nHas a chance to confuse enemies");
		}
		public override void SetDefaults()
		{
			item.damage = 20;
			item.melee = true;
			item.width = 60;
			item.height = 60;
			item.useTime = 35;
			item.useAnimation = 35;
			item.useStyle = 1;
			item.knockBack = 7;
			item.useTurn = true; //this allows the movement of sword like muramasa
            item.value = Item.sellPrice(0, 1, 0, 0);
			item.rare = 1;
			item.UseSound = SoundID.Item1;
            item.autoReuse = true;            
			item.shootSpeed = 10f;

		}
        
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
			if(Main.rand.Next(5) == 0)
			{
			target.AddBuff(31, 240); //confused debuff
			}
		}


		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 5);
            recipe.AddIngredient(ItemID.StoneBlock, 20);
            recipe.AddIngredient(ItemID.MarbleBlock, 5);
            recipe.AddIngredient(ItemID.GraniteBlock, 5);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}
