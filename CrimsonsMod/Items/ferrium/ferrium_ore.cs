using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;         
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.ferrium
{
	public class ferrium_ore : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ferrium Ore");			
			Tooltip.SetDefault("Seeped magma from the ocean floor");
		}

		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 16;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.rare = 1;
            item.value = Item.sellPrice(0, 0, 10, 0);
			item.createTile = mod.TileType("Ferrium_Ore");
		}

	}
}