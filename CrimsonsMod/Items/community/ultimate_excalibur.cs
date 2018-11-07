using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.community
{
	public class ultimate_excalibur : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ultimate Excalibur");
			Tooltip.SetDefault("'YEET'");
		}
		public override void SetDefaults()
		{
			item.damage = 34;
			item.melee = true;
			item.width = 94;
			item.height = 94;
			item.useTime = 5;
			item.useAnimation = 5;
            item.scale = 1.8f;
			item.useStyle = 1;
			item.knockBack = 5;
            item.value = Item.sellPrice(0, 0, 0, 0);
			item.rare = -1;
			item.UseSound = SoundID.Item1;
            item.autoReuse = true;            
			item.shootSpeed = 10f;
            item.shoot = 79; //rainbow rod

		}
        
 
	}
}
