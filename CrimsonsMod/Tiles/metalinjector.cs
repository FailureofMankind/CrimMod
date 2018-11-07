using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CrimsonsMod.Tiles
{
	public class metalinjector : ModTile
	{
		public override void SetDefaults()
		{
			minPick = 51;
			drop = mod.ItemType("metalinfuser");
			AddMapEntry(new Color(200, 200, 200));
		}
	
	public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
    {
        r = 0.5f;
        g = 0.5f;
        b = 0.5f;
    }
	public override bool CanExplode(int i, int j)
	{
	if (Main.tile[i, j].type == mod.TileType("metalinfuser"))
	{
		return false;
	}
	return false;
	}	

	
	}
}