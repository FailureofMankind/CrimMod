using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.manganese
{
	[AutoloadEquip(EquipType.Head)]
	public class manganese_helmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Manganese Helmet");
			Tooltip.SetDefault("10% increased critical strike chance");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 28;
			item.value = 10000;
			item.rare = 1;
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
			return body.type == mod.ItemType("manganese_chainmail") && legs.type == mod.ItemType("manganese_legging");
		}
    

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "15% increased movement speed\nProvides immunity to poison\nAllows free movement in water";					
            player.buffImmune[20] = true;            
			
            player.moveSpeed += 0.15f;
            
            player.ignoreWater = true;
        }

		public override void ArmorSetShadows(Player player)
		{
			player.armorEffectDrawShadowSubtle = true;
		}		

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "manganese_bar", 4);
			recipe.AddIngredient(null, "DryScales", 4);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}