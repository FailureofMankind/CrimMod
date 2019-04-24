using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.crispycomb
{
	public class poison_piercer : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Poison Piercers");
			Tooltip.SetDefault("redacted");
		}
		public override void SetDefaults()
		{
			item.damage = 32;
			item.thrown = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 13;
			item.useAnimation = 13;
			item.noUseGraphic = true;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = 0;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 5f;
			item.shoot = mod.ProjectileType ("poison_piercer_proj");
            item.consumable = true;
            item.maxStack = 999;
		}
	}
}
