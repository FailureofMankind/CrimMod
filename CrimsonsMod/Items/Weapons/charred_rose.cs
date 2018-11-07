using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons
{
	public class charred_rose : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blood Rose");	
			Tooltip.SetDefault("Shoot a glob of blood that splits into lingering orbs on impact");
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults()
		{
			item.damage = 9;
			item.magic = true;
			item.mana = 3;
			item.width = 64;
			item.height = 64;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 1;
			item.UseSound = SoundID.NPCHit13;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("blood_rose");
			item.shootSpeed = 8f;
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ViciousMushroom, 5);
			recipe.AddIngredient(null, "parasitic_organ", 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}