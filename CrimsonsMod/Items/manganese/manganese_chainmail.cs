using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.manganese
{
	[AutoloadEquip(EquipType.Body)]
	public class manganese_chainmail : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Manganese Chainmail");
			Tooltip.SetDefault("'Feels dry...'\n5% increased damage\nGives you a boost in liquids");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 20;
			item.value = 10000;
			item.rare = 1;
			item.defense = 5;
		}

		public override void UpdateEquip(Player player)
		{
			player.meleeDamage *= 1.05f;
			player.rangedDamage *= 1.05f;
			player.magicDamage *= 1.05f;
			player.minionDamage *= 1.05f;
            
            player.AddBuff(109, 2);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "manganese_bar", 9);
			recipe.AddIngredient(null, "DryScales", 7);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}