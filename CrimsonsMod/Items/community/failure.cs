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
	public class failure : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Failure");
			Tooltip.SetDefault("Vanity Item\n'The One. The Only. The Failure'");
		}

		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 26;
			item.value = 0;
			item.rare = -12;
		}
	}
}