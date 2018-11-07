using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.ferrium
{
	[AutoloadEquip(EquipType.Body)]
	public class ferrium_armor : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Ferrium Armor");
			Tooltip.SetDefault("\n5% increased damage\n10% decreased mana usage\nProvides immunity to cold debuffs");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 20;
			item.value = 10000;
			item.rare = 3;
			item.defense = 10;
		}

		public override void UpdateEquip(Player player)
		{
			player.meleeDamage *= 1.05f;
			player.rangedDamage *= 1.05f;
			player.magicDamage *= 1.05f;
			player.minionDamage *= 1.05f;
            
            player.buffImmune[44] = true;            
            player.buffImmune[46] = true;            
            player.buffImmune[47] = true;            
		}

		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HellstoneBar, 10);
            recipe.AddIngredient(null, "ferrium_plating", 15);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}