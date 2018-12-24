using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.tideStrider
{
	[AutoloadEquip(EquipType.Head)]
	public class tideStrider_helm : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Tide Strider Leggings");
			Tooltip.SetDefault("You shine underwater!");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 28;
			item.value = 10000;
			item.rare = 1;
			item.defense = 2;
		}

		public override void UpdateEquip(Player player)
		{
            if(player.wet)
            {
			    Lighting.AddLight((int)(player.position.X + (float)(player.width / 2)) / 16, (int)(player.position.Y + (float)(player.height / 2)) / 16, 0.2f, 1f, .7f);
            }
			else
			{
			    Lighting.AddLight((int)(player.position.X + (float)(player.width / 2)) / 16, (int)(player.position.Y + (float)(player.height / 2)) / 16, 0f, 0.1f, 0.3f);
			}
    	}
		
        
        public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("tideStrider_chainmail") && legs.type == mod.ItemType("tideStrider_legging");
		}
    

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Defense increased by 5 when underwater\nGetting hurt gives you Aquatic Rush which gives you increased movement speed";
			
            if(player.wet)
            {
			    player.statDefense += 5;
            }
			CrimsonPlayer modplayer = player.GetModPlayer<CrimsonPlayer>(mod);
            modplayer.tideStrider = true;
        }
		
        public override void ArmorSetShadows(Player player)
		{
			player.armorEffectDrawShadowBasilisk = true;
		}		

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "tideScale", 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}