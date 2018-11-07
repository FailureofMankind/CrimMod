using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;         
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
namespace CrimsonsMod.Items.manganese
{
	public class DryScales : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dry Scales");			
			Tooltip.SetDefault("Strong scales that protected a giant turtle");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
            item.value = Item.sellPrice(0, 0, 0, 45);
			item.rare = 1;
		}
	}
}
