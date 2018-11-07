using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons
{
	public class star_scourge : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Star Scourge");
			Tooltip.SetDefault("'From the distant galaxies...\nThrow astral scourges that latches onto enemies");
		}
		public override void SetDefaults()
		{
			item.damage = 13;
			item.thrown = true;
			item.width = 64;
			item.height = 64;
			item.useTime = 30;
			item.useAnimation = 30;
			item.noUseGraphic = true;
			item.useStyle = 1;
			item.knockBack = 0;
            item.value = Item.sellPrice(0, 2, 10, 0);
			item.rare = 3;
			item.UseSound = SoundID.Item66;
			item.autoReuse = true;
			item.shootSpeed = 9f;
			item.shoot = mod.ProjectileType ("star_scourge");

		}
	}
}
