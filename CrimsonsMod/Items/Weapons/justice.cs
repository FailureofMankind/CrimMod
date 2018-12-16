using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons
{
	public class justice : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Justice");
			Tooltip.SetDefault("'The wind howls...'"+
                                "\nLeft click to throw a blue beam of your unbeatable soul"+
                                "\nRight click to throw a yellow beam that always return to you no matter what");
		}
		public override void SetDefaults()
		{
			item.damage = 30;
			item.magic = true;
			item.width = 54;
			item.height = 54;
			item.useTime = 6;
			item.useAnimation = 6;
            item.mana = 2;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.useStyle = 1;
			item.knockBack = 1;
			item.value = 1000;
			item.rare = 8;
			item.UseSound = SoundID.Item43;
			item.autoReuse = true;
			item.shootSpeed = 15f;
			item.shoot = 0;

		}

        public override bool AltFunctionUse(Player player)
		{
			return true;
		}

		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
                item.useTime = 7;
                item.useAnimation = 7;							
                item.shoot = mod.ProjectileType("justice_yellow");
			}
			else
			{
                item.useTime = 3;
                item.useAnimation = 3;			
                item.shoot = mod.ProjectileType("justice_blue");
			}
			return base.CanUseItem(player);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BatScepter);						
			recipe.AddIngredient(ItemID.SpectreStaff);						
			recipe.AddIngredient(ItemID.Ectoplasm, 8);
			recipe.AddIngredient(ItemID.SoulofMight, 15);
			recipe.AddIngredient(ItemID.LifeCrystal);			
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();            
		}
	}
}
