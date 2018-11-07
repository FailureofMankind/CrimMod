using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.ferrium
{
	[AutoloadEquip(EquipType.Head)]
	public class ferrium_helmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Ferrium Helmet");
			Tooltip.SetDefault("Increased max minions by 3\n");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 28;
			item.value = 10000;
			item.rare = 3;
			item.defense = 4;
		}

		public override void UpdateEquip(Player player)
		{
			player.thrownCrit += 10;
			player.meleeCrit += 10;
			player.rangedCrit += 10;
			player.magicCrit += 10;
		}
		
        
        public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("ferrium_armor") && legs.type == mod.ItemType("ferrium_legging");
		}
    

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "15% increased damage\nIncreased life and mana regeneration\nMelee weapons set enemies ablaze when hit by the blade\nYou take more damage";
			player.thrownDamage *= 1.15f;
			player.meleeDamage *= 1.15f;
			player.magicDamage *= 1.15f;
			player.rangedDamage *= 1.15f;
			player.minionDamage *= 1.15f;

			player.lifeRegen += 3;
			player.manaRegen += 25;

			player.endurance = -1.3f;

			CrimsonPlayer modplayer = player.GetModPlayer<CrimsonPlayer>(mod);				//refer to the CrimsonPlayer file
			modplayer.ferrium = true;

        
		
		}

		public override void ArmorSetShadows(Player player)
		{
			player.armorEffectDrawShadowSubtle = true;
		}		

		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HellstoneBar, 3);
            recipe.AddIngredient(null, "ferrium_plating", 6);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}