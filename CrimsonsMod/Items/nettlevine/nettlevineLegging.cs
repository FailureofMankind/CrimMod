using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.nettlevine
{
	[AutoloadEquip(EquipType.Legs)]
	public class nettlevineLegging : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Nettlevine Legging");
			Tooltip.SetDefault("5% increased movement speed\nWhen under 50% health, 20% increased movement speed");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 18;
            item.value = Item.sellPrice(0, 0, 5, 0);
			item.rare = 3;
			item.defense = 3;
		}

		public override void UpdateEquip(Player player)
		{
            if(player.statLife < (player.statLifeMax * 0.5))
            {
                player.moveSpeed += 20f;
            }
            else
            {
                player.moveSpeed += 5f;
            }
		}

		public override void AddRecipes()
		{
			ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(null, "poisonVine", 5);
			recipe1.AddIngredient(ItemID.Vine, 3);
			recipe1.AddIngredient(ItemID.JungleSpores, 4);
			recipe1.AddIngredient(ItemID.ShadowScale, 5);
			recipe1.AddTile(TileID.Anvils);
			recipe1.SetResult(this);
			recipe1.AddRecipe();

			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient(null, "poisonVine", 5);
			recipe2.AddIngredient(ItemID.Vine, 3);
			recipe2.AddIngredient(ItemID.JungleSpores, 4);
			recipe2.AddIngredient(ItemID.TissueSample, 5);
			recipe2.AddTile(TileID.Anvils);
			recipe2.SetResult(this);
			recipe2.AddRecipe();
		}
	}
}