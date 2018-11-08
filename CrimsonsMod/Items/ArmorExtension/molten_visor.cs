using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.ArmorExtension
{
	[AutoloadEquip(EquipType.Head)]
	public class molten_visor : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Molten Visor");
			Tooltip.SetDefault("Increased thrown damage by 15%");
		}

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.value = 10000;
			item.rare = 3;
			item.defense = 4;
		}

		public override void UpdateEquip(Player player)
		{
			player.thrownDamage *= 1.15f;
		}
		
        
        public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ItemID.MoltenBreastplate && legs.type == ItemID.MoltenGreaves;
		}
    

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "13% increased thrown critical strike chance\n50% chance to not consume thrown items\nIncreased throwing velocity";
			player.thrownCrit += 13;
            player.thrownCost50 = true; //50% chance not to consume thrown item

            player.thrownVelocity *= 5f;
 		}

		public override void ArmorSetShadows(Player player)
		{
			player.armorEffectDrawShadowSubtle = true;
		}		

		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HellstoneBar, 8);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}