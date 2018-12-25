using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.nettlevine
{
	[AutoloadEquip(EquipType.Body)]
	public class nettlevineScalemail : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Nettlevine Scalemail");
			Tooltip.SetDefault("5% increased ranged/melee damage");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 20;
            item.value = Item.sellPrice(0, 0, 10, 0);
			item.rare = 3;
			item.defense = 6;
		}

		public override void UpdateEquip(Player player)
		{
			player.rangedDamage += 0.05f;
			player.meleeDamage += 0.05f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Vine, 4);
			recipe.AddIngredient(ItemID.JungleSpores, 10);
			recipe.AddIngredient(ItemID.Stinger, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}