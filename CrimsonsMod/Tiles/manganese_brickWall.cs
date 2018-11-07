using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CrimsonsMod.Tiles
{
	public class manganese_brickWall : ModWall
{
    public override void SetDefaults()
    {
        Main.wallHouse[Type] = true;
        drop = mod.ItemType("manganese_brickWall");
	AddMapEntry(new Color(121, 233, 167));
    }
}}