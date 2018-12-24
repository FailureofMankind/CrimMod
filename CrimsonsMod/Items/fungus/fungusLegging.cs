using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.fungus
{
	[AutoloadEquip(EquipType.Legs)]
	public class fungusLegging : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Fungal Greaves");
			Tooltip.SetDefault("6% increased magic crit chance");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 18;
            item.value = Item.sellPrice(0, 0, 5, 0);
			item.rare = 2;
			item.defense = 2;
		}

		public override void UpdateEquip(Player player)
		{
            player.magicCrit += 6;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GlowingMushroom, 4);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}