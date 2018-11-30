using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.bossSummoner
{
	public class wretchedBait : ModItem
	{
		public override void SetDefaults()
		{

			item.width = 28;
			item.height = 32;
			item.maxStack = 20;
			item.useTurn = true;
			item.autoReuse = false;
			item.useAnimation = 18;
			item.useTime = 18;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wretched Bait");
			Tooltip.SetDefault("Summons a horrific entity");
		}

		public override bool CanUseItem(Player player)
		{
			return !NPC.AnyNPCs(mod.NPCType("sea_turtle")) && !Main.dayTime;
		}

		public override bool UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("tormentor_of_souls"));
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}

		/*public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Mushroom, 8);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
		}*/
	}
}
