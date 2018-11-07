using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CrimsonsMod.Tiles
	{
		public class aluminum_ore : ModTile
		{
			public override void SetDefaults()
			{
				Main.tileSpelunker[Type] = true;
				Main.tileSolid[Type] = true;
				Main.tileMergeDirt[Type] = true;
				Main.tileBlockLight[Type] = true;
				minPick = 65;
				ModTranslation name = CreateMapEntryName();
				name.SetDefault("Aluminum Ore");
				drop = mod.ItemType("aluminum_ore");
				AddMapEntry(new Color(200, 200, 200));
			}
		
		public override bool CanExplode(int i, int j)
		{
			if (Main.tile[i, j].type == mod.TileType("aluminum_ore"))
			{
				return false;
			}
			return false;
		}	

		
		}
	}