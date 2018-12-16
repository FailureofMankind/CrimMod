using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Accessories
{
    [AutoloadEquip(EquipType.Shield)]
	public class ice_core_shield : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ice-Core Shield");
			Tooltip.SetDefault("You release crystals on being hit");
		}
        public override void SetDefaults()
        {
            item.width = 34;
            item.height = 34;
            item.value = 10000;
            item.rare = 6;
            item.defense = 5;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			CrimsonPlayer modplayer = player.GetModPlayer<CrimsonPlayer>(mod);
            modplayer.iceCoreShield = true;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrystalShard, 5);
            recipe.AddIngredient(null, "crystal_geode", 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    
    }
}