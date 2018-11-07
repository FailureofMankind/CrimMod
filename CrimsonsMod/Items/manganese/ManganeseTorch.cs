using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.Items.manganese
{
	public class ManganeseTorch : ModItem
	{
		public override void SetDefaults()
		{

			item.width = 10;
			item.height = 12;
			item.maxStack = 99;
			item.holdStyle = 1;
			item.noWet = true;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("ManganeseTorch");
			item.flame = true;
			item.value = 0;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Manganese Torch");
			Tooltip.SetDefault("Burns hot underwater, but can crumble away under certain circumstances, so be careful");
		}

		public override void PostUpdate()
		{
			if (!item.wet)
			{
				Lighting.AddLight((int)((item.position.X + item.width / 2) / 16f), (int)((item.position.Y + item.height / 2) / 16f), 1f, 1f, 1f);
			}
		}

		public override void AutoLightSelect(ref bool dryTorch, ref bool wetTorch, ref bool glowstick)
		{
			dryTorch = true;
		}
		
		public override void AddRecipes()
		{
			ModRecipe a = new ModRecipe(mod);
			a.AddIngredient(ItemID.Torch);
			a.AddIngredient(null, "manganese_brick", 1);
			a.SetResult(this);
			a.AddRecipe();
        }
	}
}
