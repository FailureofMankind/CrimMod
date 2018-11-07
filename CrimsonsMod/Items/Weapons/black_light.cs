using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons
{
	public class black_light : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Black Light");	
			Tooltip.SetDefault("owo glowy");
		}

		public override void SetDefaults()
		{
			item.damage = 20;
			item.magic = true;
			item.mana = 9;
			item.width = 64;
			item.height = 64;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 3;
			item.value = 10000;
			item.rare = 2;
			item.autoReuse = true;
			item.shootSpeed = 2f;
			item.shoot = mod.ProjectileType("Blacklight");
		}	
	}
}