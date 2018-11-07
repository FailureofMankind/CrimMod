using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CrimsonsMod.Tiles
{
	public class manganese_brick : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSpelunker[Type] = false;
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			minPick = 35;
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Manganese Brick");
			drop = mod.ItemType("manganese_brick");
			AddMapEntry(new Color(121, 233, 167));
		}
	}
}