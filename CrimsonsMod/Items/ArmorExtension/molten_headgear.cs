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
	public class molten_headgear : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Molten Headgear");
			Tooltip.SetDefault("Increased ranged damage by 5%");
		}

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.value = 10000;
			item.rare = 3;
			item.defense = 6;
		}

		public override void UpdateEquip(Player player)
		{
			player.rangedDamage *= 1.05f;
		}
		
        
        public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ItemID.MoltenBreastplate && legs.type == ItemID.MoltenGreaves;
		}
    

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "10% increased ranged damage\n45% chance to not consume ammo";
			player.rangedDamage *= 1.10f;

            player.ammoCost75 = true; //25% reduced ammo usage
            player.ammoCost80 = true;//20% reduced ammo usage   
            // yeah theres no hook for which i can just put a float for ammo cost reduction oof
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