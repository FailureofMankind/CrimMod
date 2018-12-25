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
        public override bool InstancePerEntity
        {
            get
            {
                return true;
            }
        }        
        
        public override void NPCLoot(NPC npc)
        {
            //boss drops
            if (npc.type == NPCID.EyeofCthulhu && !Main.expertMode)  
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("bloodTear"), Main.rand.Next(6, 24));
            }

            //biome enemy drops

            
            //others i guess
        }
    }
}