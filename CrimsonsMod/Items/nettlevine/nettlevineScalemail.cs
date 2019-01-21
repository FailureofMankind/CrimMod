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
			ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(null, "poisonVine", 5);
			recipe1.AddIngredient(ItemID.JungleSpores, 5);
			recipe1.AddIngredient(ItemID.Stinger, 2);
			recipe1.AddIngredient(ItemID.ShadowScale, 5);
			recipe1.AddTile(TileID.Anvils);
			recipe1.SetResult(this);
			recipe1.AddRecipe();

			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient(null, "poisonVine", 5);
			recipe2.AddIngredient(ItemID.JungleSpores, 5);
			recipe2.AddIngredient(ItemID.Stinger, 2);
			recipe2.AddIngredient(ItemID.TissueSample, 5);
			recipe2.AddTile(TileID.Anvils);
			recipe2.SetResult(this);
			recipe2.AddRecipe();
		}
	}
}