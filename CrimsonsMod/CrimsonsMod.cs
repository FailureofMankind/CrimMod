using System.IO;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace CrimsonsMod
{
	class CrimsonsMod : Mod
	{
		public CrimsonsMod()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}

		/*public override void PostSetupContent()
		{	
			Mod bossList = ModLoader.GetMod("BossChecklist"); //thancc blushiemagic
			if(bossList != null)
			{
				bossList.Call("AddBossWithInfo", "Turroise", 0.9f, (Func<bool>)(() => BluemagicWorld.downedPhantom), string.Format("Use a [i:{0}] anywhere at night", ItemType("TastyMorsel")));
			}
		}*/
	
	
	
	
	
	}
}
