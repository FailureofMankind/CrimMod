using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.Weapons.shortswords
{
	public class elemental_dagger : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Elemental Dagger");
			Tooltip.SetDefault("'yo i heard yall like debuffs so....... -blushie'\nInflicts onfire, frostburn, poisoned, confused, cursed inferno, ichor\nHitting enemies with the blade causes an explosion of mushrooms"); //'rated -7.5/10; not enough water'\n
		}
		public override void SetDefaults()
		{
			item.damage = 37;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 11;
			item.useAnimation = 11;
			item.useStyle = 3;
			item.useTurn = true;
			item.knockBack = 5;
            item.value = Item.sellPrice(0, 10, 0, 0);
			item.rare = 6;
			item.UseSound = SoundID.Item1;
            item.autoReuse = true; 

		}
        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
			target.AddBuff(20, 800); //buff id poisoned
			target.AddBuff(24, 800); //buff id onfire
			target.AddBuff(39, 800); //buff id cursed inferno
			target.AddBuff(44, 800); //buff id frostburn
			target.AddBuff(69, 1200); //buff id ichor
			target.AddBuff(31, 300); //buff id confused


			for (int i = 0; i<Main.rand.Next(5, 35); i++)
            {
            Projectile.NewProjectile(player.position.X, (int)(player.position.Y + 20), Main.rand.Next(-40, 40), Main.rand.Next(-40, 40), 131, damage, knockback, player.whoAmI, 0f, 0f);
			}
		}

		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "wooden_shortsword");
            recipe.AddIngredient(null, "blazing_stabber");
            recipe.AddIngredient(null, "minisama");
            recipe.AddIngredient(null, "icicle");
            recipe.AddIngredient(null, "feral_knife");
            recipe.AddIngredient(null, "sands_of_magic", 50);
            recipe.AddIngredient(ItemID.SoulofLight, 12);
            recipe.AddIngredient(ItemID.SoulofNight, 12);
			recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }




	}
}
