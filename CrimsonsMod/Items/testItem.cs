using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items
{
	public class testItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Test Item");
			Tooltip.SetDefault("Currently Testing: water volt proj");
        }
		public override void SetDefaults()
		{
			item.damage = 10;
			item.width = 56;
			item.height = 20;
			item.useTime = 3;
			item.useAnimation = 3;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 0;
			item.rare = -2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 10f;
            item.shoot = mod.ProjectileType("barkwoodProjShot");

		}        

	}
}
