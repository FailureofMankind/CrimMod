using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.aluminum
{
    public class heavyduty_repeater : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Heavy-duty Repeater");
			Tooltip.SetDefault("A fast pulse shot that has 33% chance to not consume arrow");
		}

        public override void SetDefaults()
        {
            item.damage = 11;
            item.noMelee = true;
            item.ranged = true;
            item.width = 28;
            item.height = 40;
            item.useTime = 11;
            item.useAnimation = 11;
            item.useStyle = 5;
            item.shoot = 3;
            item.useAmmo = AmmoID.Arrow;
            item.knockBack = 0;
            item.value = Item.sellPrice(0, 0, 95, 0);
            item.rare = 2;
            item.UseSound = SoundID.Item5;
            item.autoReuse = true;
            item.shootSpeed = 13f;

        }

        public override bool ConsumeAmmo(Player player)
            {
                return Main.rand.NextFloat() >= .33f;
            }           
        
        
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "aluminum_bar", 17);
            recipe.AddTile(TileID.Anvils);  //this is where to craft the item ,WorkBenches = all WorkBenches    Anvils = all anvils , MythrilAnvil = Mythril Anvil and Orichalcum Anvil, Furnaces = all furnaces , DemonAltar = Demon Altar and Crimson Altar , TinkerersWorkbench = Tinkerer's Workbench
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

    }
}