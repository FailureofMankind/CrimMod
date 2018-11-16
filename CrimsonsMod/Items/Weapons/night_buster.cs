using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons
{
    public class night_buster : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Night Buster");
			Tooltip.SetDefault("'cool and good.'\nAt night, damage is increased but slower use speed\nAt day, damage is decreased but faster use speed");
		}

        public override void SetDefaults()
        {
            item.damage = 20;
            item.noMelee = true;
            item.magic = true;
            item.mana = 6;
            item.width = 48;
            item.height = 22;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 5;
            item.knockBack = 3;
            item.value = Item.sellPrice(0, 1, 30, 0);
            item.rare = 4;
            item.UseSound = SoundID.Item75;
            item.autoReuse = true;
            item.shootSpeed = 10f;

        }
        int temporalProj = 0;
        public override void UpdateInventory(Player player) //tremor oof
        {
            if(Main.dayTime)
            {
                item.damage = 20;
                item.useTime = 15;
                item.useAnimation = 15;
                item.mana = 2;
                item.shoot = 260;
            }
            if(!Main.dayTime)
            {
                item.damage = 45;
                item.useTime = 30;
                item.useAnimation = 30;
                item.mana = 10;
                item.shoot = 294;
            }
        }
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-3, 0);
		}          
          
/*
        public override void AddRecipes()
        
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ClayBlock, 24);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }*/
    }
}