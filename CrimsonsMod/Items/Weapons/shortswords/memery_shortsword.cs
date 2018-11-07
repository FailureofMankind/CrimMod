using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons.shortswords
{
	public class memery_shortsword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Memery Shortswoart");
			Tooltip.SetDefault("'seizure warning lmao its lit fam'\n--Rare Drop--");
		}
		public override void SetDefaults()
		{
			item.damage = 1000;
			item.melee = true;
			item.width = 52;
			item.height = 52;
			item.useTime = 3;
			item.useAnimation = 3;
			item.useStyle = 3;
			item.knockBack = 8;
            item.value = Item.sellPrice(0, 1, 0, 0);
			item.rare = -12;
			item.UseSound = SoundID.Item1;
            item.autoReuse = true;    
			item.shoot = mod.ProjectileType("meme");
			item.shootSpeed = 10f;


		}
 

	}
}
