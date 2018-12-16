using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CrimsonsMod.Tiles
{
	public class placeholderTile : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSpelunker[Type] = true;
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			minPick = 35;
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Placeholder");
			drop = mod.ItemType("manganese_ore");
			AddMapEntry(new Color(0, 0, 0), name);
		}


		public override bool CanExplode(int i, int j)
		{
		if (Main.tile[i, j].type == mod.TileType("placeholderTile"))
		{
			return false;
		}
		return false;
		}	

	
	}
}