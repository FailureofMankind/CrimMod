using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.ferrium
{
	[AutoloadEquip(EquipType.Legs)]
	public class ferrium_legging : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Ferrium Leggings");
			Tooltip.SetDefault("There is a mini jetpack in these boots!\nProvides immunity to heat");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 18;
			item.value = 100;
			item.rare = 3;
			item.defense = 5;
		}

		public override void UpdateEquip(Player player)
		{
            player.AddBuff(1, 2);
			player.rocketBoots = 1;
            
		}
		

		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HellstoneBar, 5);
            recipe.AddIngredient(null, "ferrium_plating", 8);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}