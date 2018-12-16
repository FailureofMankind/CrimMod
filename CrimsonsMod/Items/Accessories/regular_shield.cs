using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Accessories
{
    [AutoloadEquip(EquipType.Shield)]
	public class regular_shield : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Useful Shield");
			Tooltip.SetDefault("5% decreased movement speed");
		}
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 28;
            item.value = 10;
            item.rare = 1;
            item.defense = 2;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.moveSpeed -= 0.05f;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddIngredient(ItemID.StoneBlock, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    
    }
}