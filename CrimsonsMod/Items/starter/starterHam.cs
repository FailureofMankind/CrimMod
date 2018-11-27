using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.starter
{
	public class starterHam : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Simple Hammer");
			Tooltip.SetDefault("'Clobberin' time! a bit later...'");
		}
		public override void SetDefaults()
		{
			item.damage = 5;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 20;
			item.useAnimation = 35;
			item.useTurn = true;
            item.hammer = 35;
            item.tileBoost += 4;         
			item.useStyle = 1;
			item.knockBack = 6;
            item.value = Item.sellPrice(0, 0, 0, 10);
			item.rare = 0;
			item.UseSound = SoundID.Item1;
            item.autoReuse = true;            

		}

	}
}
