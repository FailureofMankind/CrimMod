using System.IO;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.World.Generation;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Generation;
using Terraria.ModLoader.IO;
using Terraria.DataStructures;
using Microsoft.Xna.Framework.Graphics;

namespace CrimsonsMod.NPCs
{
    public class ModGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            //boss drops
            if (npc.type == 4)  //eye of cthulu
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("bloodTear"), Main.rand.Next(12, 18));
            }
            if (npc.type == mod.NPCType("tormentor_of_souls") && !Main.expertMode)  
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("bileSac"), Main.rand.Next(15, 30));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.RottenChunk, Main.rand.Next(10, 20));
            }
            //biome enemy drops

            
            //progression
            if (npc.type == mod.NPCType("tormentor_of_souls"))  
            {
                if (!CrimsonsWorld.evilBossJungleActivation)
                {                                                               
                    Main.NewText("The jungle flourishes with its fauna", 107, 216, 68); 
                }
                
                CrimsonsWorld.evilBossJungleActivation = true; 
            }

        }
    }
}