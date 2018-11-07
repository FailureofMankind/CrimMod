using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.manganese
{
    public class dry_seas : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dry Seas");
            Tooltip.SetDefault("Cast a blast of aqueous energy");
        }

        public override void SetDefaults()
        {
            item.damage = 10;//The damage stat for the Weapon.
            item.width = 40;
            item.height = 42;
            item.magic = true;     //This defines if it does Melee damage and if its effected by Melee increasing Armor/Accessories.
            item.useTime = 25;  //How fast the Weapon is used.
            item.useAnimation = 25;   //How long the Weapon is used for.
            item.mana = 3;
            item.value = Item.sellPrice(0, 0, 90, 0);
            item.useStyle = 5;//The way your Weapon will be used, 1 is the regular sword swing for example
            item.knockBack = 4;//The knockback stat of your Weapon.
            item.rare = 1;//The color the title of your Weapon when hovering over it ingame   
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("dry_bolt"); //This defines what type of projectile this weapon will shot	
            item.shootSpeed = 3f;
            item.noMelee = true;// Makes sure that the animation when using the item doesn't hurt NPCs.
            item.UseSound = SoundID.Item13; //The sound played when using your Weapon
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            for (int i = 0; i < 3; i++)
            {
                Projectile.NewProjectile((int)(position.X + Main.rand.Next(-5, 5)), (int)(position.Y + Main.rand.Next(-5, 5)), (int)(speedX + Main.rand.Next(-5, 5)), (int)(speedY + Main.rand.Next(-5, 5)), mod.ProjectileType("dry_bolt"), damage, knockBack, player.whoAmI, 0f, 0f); //This is spawning a projectile of type FrostburnArrow using the original stats
            }
            return false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "manganese_bar", 10);
            recipe.AddIngredient(ItemID.Book);
			recipe.AddIngredient(null, "DryScales", 5);
            recipe.AddTile(TileID.Anvils);  //this is where to craft the item ,WorkBenches = all WorkBenches    Anvils = all anvils , MythrilAnvil = Mythril Anvil and Orichalcum Anvil, Furnaces = all furnaces , DemonAltar = Demon Altar and Crimson Altar , TinkerersWorkbench = Tinkerer's Workbench
            recipe.SetResult(this);
            recipe.AddRecipe();

            ModRecipe book = new ModRecipe(mod);
            book.AddIngredient(null, "paper", 25);
            book.AddIngredient(ItemID.Cactus, 2);
            book.AddTile(TileID.Anvils);  //this is where to craft the item ,WorkBenches = all WorkBenches    Anvils = all anvils , MythrilAnvil = Mythril Anvil and Orichalcum Anvil, Furnaces = all furnaces , DemonAltar = Demon Altar and Crimson Altar , TinkerersWorkbench = Tinkerer's Workbench
            book.SetResult(ItemID.Book);
            book.AddRecipe();

        }
    }
}