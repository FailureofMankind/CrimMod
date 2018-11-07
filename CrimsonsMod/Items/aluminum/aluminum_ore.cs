using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;         
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.aluminum
{
	public class aluminum_ore : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bauxite Ore");			
			Tooltip.SetDefault("Contains aluminum marbled in obsidian");
		}

		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 14;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.rare = 2;
            item.value = Item.sellPrice(0, 0, 30, 0);
			item.createTile = mod.TileType("aluminum_ore");
		}

	}
}