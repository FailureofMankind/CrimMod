using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.aluminum
{
	[AutoloadEquip(EquipType.Head)]
	public class aluminum_helmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Aluminum Helmet");
			Tooltip.SetDefault("15% increased magic and melee damage\n+2 increased max minions");
            
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 28;
			item.value = 10000;
			item.rare = 2;
			item.defense = 3;
		}

		public override void UpdateEquip(Player player)
		{
			player.meleeDamage *= 1.15f;
			player.magicDamage *= 1.15f;
			player.maxMinions += 2;
		}
		
        
        public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("aluminum_armor") && legs.type == mod.ItemType("aluminum_legging");
		}
    

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "5% increased damage\nYou are very heavy and fall faster\n12% increased damage reduction";
			
            player.thrownDamage *= 1.05f;
			player.meleeDamage *= 1.05f;
			player.magicDamage *= 1.05f;
			player.rangedDamage *= 1.05f;
			player.minionDamage *= 1.05f;

            player.maxFallSpeed *= 1.30f;
            
            player.endurance *= 0.12f;
        }
		
        public override void ArmorSetShadows(Player player)
		{
			player.armorEffectDrawShadowSubtle = true;
		}		

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "aluminum_bar", 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}