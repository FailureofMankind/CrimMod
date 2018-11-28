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
	public class fire_mages_hat : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Fire Mage's Hat");
			Tooltip.SetDefault("Increased magic damage by 6%");
		}

		public override void SetDefaults()
		{
			item.width = 48;
			item.height = 48;
			item.value = 10000;
			item.rare = 3;
			item.defense = 3;
		}

		public override void UpdateEquip(Player player)
		{
		}
		
        
        public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ItemID.MoltenBreastplate && legs.type == ItemID.MoltenGreaves;
		}
    

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "10% increased magic damage and critical strike chance\nMana flower effect\n'How does one see through this?'";
			player.magicCrit += 10;
			player.magicDamage += +.10f;
            
            player.manaFlower = true;

		
		}

		public override void ArmorSetShadows(Player player)
		{
			player.armorEffectDrawShadowSubtle = true;
		}		

		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HellstoneBar, 4);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}