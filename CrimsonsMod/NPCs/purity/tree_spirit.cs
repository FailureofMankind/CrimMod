using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrimsonsMod.NPCs.purity
{
	// This ModNPC serves as an example of a complete AI example.
	public class tree_spirit : ModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Flutter Slime"); // Automatic from .lang files
			DisplayName.SetDefault("Tree Spirit");
			Main.npcFrameCount[npc.type] = 3; // make sure to set this for your modnpcs.
		}

		public override void SetDefaults()
		{
			npc.width = 36;
			npc.height = 52;
			animationType = 0;			
			npc.aiStyle = 22;
			npc.damage = 6;
			npc.defense = 0;
			npc.knockBackResist = 0.5f;
			npc.noGravity = true;
			npc.lifeMax = 15;
			npc.HitSound = SoundID.NPCHit7;
			npc.DeathSound = SoundID.NPCDeath8;
			npc.value = 25f; // npc default to being immune to the Confused debuff. Allowing confused could be a little more work depending on the AI. npc.confused is true while the npc is confused.
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
            return SpawnCondition.OverworldDaySlime.Chance * 0.1f;
		}

        public override void NPCLoot()
		{
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("purity_shard"), Main.rand.Next(3, 5));
		}
    }
}
