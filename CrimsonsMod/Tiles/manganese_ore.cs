using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CrimsonsMod.Tiles
{
	public class manganese_ore : ModTile
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
			name.SetDefault("Manganese Ore");
			drop = mod.ItemType("manganese_ore");
			AddMapEntry(new Color(121, 233, 167));
		}


		public override bool CanExplode(int i, int j)
		{
		if (Main.tile[i, j].type == mod.TileType("manganese_ore"))
		{
			return false;
		}
		return false;
		}	

	
	}
}