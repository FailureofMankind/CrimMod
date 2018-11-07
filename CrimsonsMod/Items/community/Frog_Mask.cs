using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.community
{
	[AutoloadEquip(EquipType.Head)]
	public class Frog_Mask : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Froggo Mask");
			Tooltip.SetDefault("Vanity Item\n'behold.... THE FROG ARMY'");
		}

		public override void SetDefaults()
		{
			item.width = 13;
			item.height = 13;
			item.value = 0;
			item.rare = -1;
		}
	}
}