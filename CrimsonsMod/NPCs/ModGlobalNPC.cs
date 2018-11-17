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
            
        /*public override void UpdateLifeRegen(NPC npc, ref int damage)
        {
            if(septic_curse == true)
            {
                npc.defence -= 5;
                npc.damage *= 0.50f;
            }
        }*/
        
        public override void DrawEffects(NPC npc, ref Color drawColor)
		{
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        public override void NPCLoot(NPC npc)
        {   
			if (npc.type == mod.NPCType("sea_turtle") && Main.hardMode && Main.rand.Next(9) == 1)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DryWings"), 1);
            }

            if (npc.type == 163)
            {
                if (Main.rand.Next(9) == 0) 
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Recluse"), 1);
                }
            }
						
			if (npc.type == mod.NPCType("AirSlime"))
            {
                if (Main.rand.Next(1) == 0)   //item rarity
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("AeroGel"), 1);
                }
            }

            if (npc.type == 250)
            {
                if (Main.rand.Next(39) == 0) 
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("volt"), 1);
                }
            }
			
			if (npc.type == 48 && MyWorld.aero_aggression && Main.rand.Next(25) == 0)
            {
                int rand = Main.rand.Next(5);

                if (rand == 0) 
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("star_scourge"), 1);
                }
                if (rand == 1) 
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Bolt"), 1);
                }
                if (rand == 2) 
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("sunstrike"), 1);
                }
                if (rand == 3) 
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("transcended"), 1);
                }
                if (rand == 4) 
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Starstriker"), 1);
                }
            
            }
			
            
            if (npc.type == NPCID.EyeofCthulhu)  
            {
                if (Main.rand.Next(3) == 0) 
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("blood_shot"), 1);
                }
            }

			if (npc.type == 35)
            {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("necromancer"), 1);
            }

            if (npc.type == NPCID.DukeFishron)  
            {
                if (Main.rand.Next(3) == 0) 
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("splash"), 1);
                }
            }

            if (npc.type == NPCID.Golem)  
            {
                if (Main.rand.Next(3) == 0) 
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("temple_raid"), 1);
                }
            }
			
			if (npc.type == mod.NPCType("aeroharpy"))
            {
                if (Main.rand.Next(1) == 0)   //item rarity
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("AeroGel"), 1);
                }
            }
			
			if (npc.type == mod.NPCType("aerobat"))
            {
                if (Main.rand.Next(1) == 0)   //item rarity
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("AeroGel"), 1);
                }
            }

            if (npc.type == 398) //moonlord
            {
                if (Main.rand.Next(6) == 0) 
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Minimere"), 1);
                }
                
            }

            if (Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].ZoneDungeon)  
            {
                if (Main.rand.Next(14) == 0) 
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("rune_stone"), Main.rand.Next(1, 10));
                }

                if(!Main.hardMode && Main.rand.Next(74) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("minisama"), 1);
                }
            }

            if (npc.type == 439)  //lunatic cultist
            {
                if (Main.rand.Next(3) == 0) 
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("polaris"), 1);
                }
            }
			
			if (npc.type == 395)  
            {
                if (Main.rand.Next(5) == 0) 
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Phobos"), 1);
                }
                if (Main.rand.Next(5) == 0) 
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Influx_Shortsword"), 1);
                }
            }

            if (Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].ZoneCorrupt)  
            {
                if(!Main.hardMode && Main.rand.Next(10) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("vile_core"), Main.rand.Next(5, 10));
                }
                if(Main.hardMode && Main.rand.Next(75) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("vile_core"), Main.rand.Next(5, 10));
                }
            }            
            if (Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].ZoneCrimson)  
            {
                if(!Main.hardMode && Main.rand.Next(10) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("parasitic_organ"), Main.rand.Next(5, 10));
                }
                if(Main.hardMode && Main.rand.Next(75) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("parasitic_organ"), Main.rand.Next(5, 10));
                }
            }            
            if (Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].ZoneOverworldHeight && !Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].ZoneCrimson && !Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].ZoneCorrupt)  
            {
                if(!Main.hardMode && Main.rand.Next(10) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("purity_shard"), Main.rand.Next(2, 5));
                }
                if(Main.hardMode && Main.rand.Next(75) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("purity_shard"), Main.rand.Next(2, 5));
                }
            }            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            //progression 
            
            if (npc.type == NPCID.QueenBee)  
            {
                if (!MyWorld.aero_aggression)
                {                                                               
                    Main.NewText("The skies shine thick with light!", 127, 193, 255); 
                }
                
                MyWorld.aero_aggression = true; 
            }
        
        








            //fucking ore spwn and I swear if you delete this you ghayhh as hell
            if(npc.type == 35 && !MyWorld.spawn_ferrium_ore)
            for (int k = 0; k < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); k++)
            {
                // The inside of this for loop corresponds to one single splotch of our Ore.
                // First, we randomly choose any coorinate in the world by choosing a random x and y value.
                // Then, we call WorldGen.TileRunner with random "strength" and random "steps", as well as the Tile we wish to place. Feel free to experiment with strength and step to see the shape they generate.
                WorldGen.TileRunner(WorldGen.genRand.Next(0, Main.maxTilesX), WorldGen.genRand.Next((int)WorldGen.rockLayer, Main.maxTilesY), (double)WorldGen.genRand.Next(1, 4), WorldGen.genRand.Next(4, 20), mod.TileType("Ferrium_Ore"), false, 0f, 0f, false, true);         
            
                if (!MyWorld.spawn_ferrium_ore)
                {                                                               
                    Main.NewText("Fiery substances rise from the core!", 252, 179, 61); 
                }                
                
                MyWorld.spawn_ferrium_ore = true; 
            }







        // memes
            if(NPC.downedMoonlord && Main.rand.Next(20000) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("memery_shortsword"), 1);
            }
        }
    }
}