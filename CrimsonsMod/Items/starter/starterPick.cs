using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.starter
{
	public class starterPick : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Simple Pickaxe");
			Tooltip.SetDefault("'perfect tool for climbing the Himalayas... or for kitchen use'");
		}
		public override void SetDefaults()
		{
			item.damage = 3;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 20;
			item.useAnimation = 35;
			item.useTurn = true;
            item.pick = 35;
			item.useStyle = 1;
			item.knockBack = 1;
            item.value = Item.sellPrice(0, 0, 0, 10);
			item.rare = 0;
			item.UseSound = SoundID.Item1;
            item.autoReuse = true;            

		}

	}
}
