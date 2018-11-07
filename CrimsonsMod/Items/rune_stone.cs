using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items
{
	public class rune_stone : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rune Stone");
			Tooltip.SetDefault("this is why the dungeon is shining....");
		}


		public override void SetDefaults()
		{

			item.width = 32;
			item.height = 32;
			item.maxStack = 999;
            item.value = Item.sellPrice(0, 0, 25, 50);
			item.rare = 3;
		}

		public override void AddRecipes()
		{
			//rune stone will be material for dungeon drops
			ModRecipe muramasa = new ModRecipe(mod);
			muramasa.AddIngredient(this, 40);
			muramasa.AddIngredient(ItemID.Bone, 15);
			muramasa.AddTile(TileID.Anvils);
			muramasa.SetResult(ItemID.Muramasa);
			muramasa.AddRecipe();

			ModRecipe aqua = new ModRecipe(mod);
			aqua.AddIngredient(this, 35);
			aqua.AddIngredient(null, "sands_of_magic", 27);
			aqua.AddIngredient(ItemID.Bone, 10);
			aqua.AddTile(TileID.Anvils);
			aqua.SetResult(ItemID.AquaScepter);
			aqua.AddRecipe();

			ModRecipe magic_missile = new ModRecipe(mod);
			magic_missile.AddIngredient(this, 40);
			magic_missile.AddIngredient(ItemID.Bone, 15);
			magic_missile.AddTile(TileID.Anvils);
			magic_missile.SetResult(ItemID.MagicMissile);
			magic_missile.AddRecipe();

			ModRecipe cobalt_shield = new ModRecipe(mod);
			cobalt_shield.AddIngredient(this, 75);
			cobalt_shield.AddIngredient(null, "aluminum_bar", 20);
			cobalt_shield.AddTile(TileID.Anvils);
			cobalt_shield.SetResult(ItemID.CobaltShield);
			cobalt_shield.AddRecipe();

			ModRecipe shadow_key = new ModRecipe(mod);
			shadow_key.AddIngredient(this, 100);
			shadow_key.AddTile(TileID.DemonAltar);
			shadow_key.SetResult(ItemID.ShadowKey);
			shadow_key.AddRecipe();

			ModRecipe handgun = new ModRecipe(mod);
			handgun.AddIngredient(this, 45);
			handgun.AddIngredient(ItemID.FlintlockPistol);
			handgun.AddTile(TileID.Anvils);
			handgun.SetResult(ItemID.Handgun);
			handgun.AddRecipe();

			ModRecipe blue_moon = new ModRecipe(mod);
			blue_moon.AddIngredient(this, 50);
			blue_moon.AddIngredient(ItemID.Chain, 18);
			blue_moon.AddTile(TileID.Anvils);
			blue_moon.SetResult(ItemID.BlueMoon);
			blue_moon.AddRecipe();
			
			ModRecipe valor = new ModRecipe(mod);
			valor.AddIngredient(this, 30);
			valor.AddIngredient(ItemID.WhiteString, 2);
			valor.AddTile(TileID.Anvils);
			valor.SetResult(ItemID.Valor);
			valor.AddRecipe();




		}


	}
}
