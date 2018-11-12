using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons.staffs
{
	public class hellion : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hellion");	
			Tooltip.SetDefault("'Thats a lot of damage!'");
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults()
		{
			item.damage = 34;
			item.magic = true;
			item.mana = 5;
			item.width = 70;
			item.height = 80;
			item.useTime = 22;
			item.useAnimation = 22;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 2;
			item.value = 10000;
			item.rare = 6;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("hellion");
			item.shootSpeed = 8f;
		}

	}
}