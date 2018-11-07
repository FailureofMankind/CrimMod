using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.AirSlime
{
    public class AeroSpell : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gust Tome");
        }

        public override void SetDefaults()
        {
            item.damage = 15;//The damage stat for the Weapon.
            item.width = 40;
            item.height = 42;
            item.magic = true;     //This defines if it does Melee damage and if its effected by Melee increasing Armor/Accessories.
            item.useTime = 25;  //How fast the Weapon is used.
            item.useAnimation = 25;   //How long the Weapon is used for.
            item.mana = 8;
            item.value = Item.sellPrice(0, 0, 90, 0);
            item.useStyle = 5;//The way your Weapon will be used, 1 is the regular sword swing for example
            item.knockBack = 4;//The knockback stat of your Weapon.
            item.rare = 3;//The color the title of your Weapon when hovering over it ingame   
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("AeroSpell"); //This defines what type of projectile this weapon will shot	
            item.shootSpeed = 3f;
            item.noMelee = true;// Makes sure that the animation when using the item doesn't hurt NPCs.
            item.UseSound = SoundID.Item13; //The sound played when using your Weapon
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            for (int i = 0; i < 10; i++)
            {
                Projectile.NewProjectile(position.X, position.Y, (int)(speedX + Main.rand.Next(-10, 10)), (int)(speedY + Main.rand.Next(-10, 10)), mod.ProjectileType("AeroSpell"), damage, knockBack, player.whoAmI, 0f, 0f); //This is spawning a projectile of type FrostburnArrow using the original stats
            }
            return false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "AeroGel", 15);
            recipe.AddIngredient(ItemID.Book);
            recipe.AddTile(TileID.Anvils);  //this is where to craft the item ,WorkBenches = all WorkBenches    Anvils = all anvils , MythrilAnvil = Mythril Anvil and Orichalcum Anvil, Furnaces = all furnaces , DemonAltar = Demon Altar and Crimson Altar , TinkerersWorkbench = Tinkerer's Workbench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}