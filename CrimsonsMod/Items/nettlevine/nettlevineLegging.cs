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
			Tooltip.SetDefault("5% increased movement speed\nWhen under 50% health, 10% increased movement speed");
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
            if(player.statLife < (player.statLifeMax * 0.5))
            {
                player.moveSpeed += 10f;
            }
            else
            {
                player.moveSpeed += 5f;
            }
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Vine, 6);
			recipe.AddIngredient(ItemID.JungleSpores, 5);
			recipe.AddIngredient(ItemID.Stinger, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}