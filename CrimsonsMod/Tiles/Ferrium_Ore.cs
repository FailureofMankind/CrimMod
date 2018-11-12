using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CrimsonsMod.Tiles
{
	public class Ferrium_Ore : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			minPick = 99;
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Ferrium Ore");
			drop = mod.ItemType("ferrium_ore");
			AddMapEntry(new Color(243, 240, 172), name);
		}

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 1f;
			g = 1f;
			b = 0.1f;
		}
		
		public override bool CanExplode(int i, int j)
		{
		if (Main.tile[i, j].type == mod.TileType("Ferrium_Ore"))
		{
			return false;
		}
		return false;
		}	
		
	}
}