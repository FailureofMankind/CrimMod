using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.starter
{
	public class starterAxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Simple Axe");
			Tooltip.SetDefault("'A beginner lumberjack's best friend...'");
		}
		public override void SetDefaults()
		{
			item.damage = 4;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useTurn = true;
            item.axe = 7;
			item.useStyle = 1;
			item.knockBack = 2;
            item.value = Item.sellPrice(0, 0, 0, 10);
			item.rare = 0;
			item.UseSound = SoundID.Item1;
            item.autoReuse = true;            

		}

	}
}
