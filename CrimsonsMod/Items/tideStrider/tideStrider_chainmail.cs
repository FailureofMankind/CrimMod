using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.tideStrider
{
	[AutoloadEquip(EquipType.Body)]
	public class tideStrider_chainmail : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Tide Strider Chainmail");
			Tooltip.SetDefault("5% increased damage when in water");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 20;
			item.value = 10000;
			item.rare = 1;
			item.defense = 4;
		}

		public override void UpdateEquip(Player player)
		{
            float damageFloat = 0.05f;
            if(player.wet)
            {
                player.meleeDamage += damageFloat;
                player.magicDamage += damageFloat;
                player.rangedDamage += damageFloat;
                player.thrownDamage += damageFloat;
                player.minionDamage += damageFloat;
            }
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "tideScale", 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}