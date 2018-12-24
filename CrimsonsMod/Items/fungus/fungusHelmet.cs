using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.fungus
{
	[AutoloadEquip(EquipType.Head)]
	public class fungusHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Fungal Helm");
			Tooltip.SetDefault("Increased magic damage by 5%");
            
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 28;
            item.value = Item.sellPrice(0, 0, 5, 0);
			item.rare = 2;
			item.defense = 2;
		}

		public override void UpdateEquip(Player player)
		{
			player.magicDamage += 0.05f;
    	}
		
        
        public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("fungusChestplate") && legs.type == mod.ItemType("fungusLegging");
		}
    

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "You occasionally spawn truffles around you";
			
			if(Main.rand.Next(89) == 1)
			{
                Projectile.NewProjectile(player.Center.X + Main.rand.Next(-300, 300), player.Center.Y + Main.rand.Next(-300, 300), 0, 0, 590, 5, 0, Main.myPlayer);                
			}
        }
		
        public override void ArmorSetShadows(Player player)
		{
			player.armorEffectDrawOutlines = true;
		}		

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GlowingMushroom, 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}