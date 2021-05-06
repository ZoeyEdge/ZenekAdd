using ZenekAdd;
using ZenekAdd.Tiles;
using ZenekAdd.NPCs;
using ZenekAdd.Items;
using ZenekAdd.Items.Accessory;
using ZenekAdd.Items.Placeable;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace ZenekAdd
{
	public class TestPlayer : ModPlayer
	{
		// start of the biome shitz
		public bool ZoneCrystalMines = false;

		public override void UpdateBiomes() 
		{
			ZoneCrystalMines = (TestMod.ZoneCrystalMinesTiles > 0);
		}
		
		public override bool CustomBiomesMatch(Player other) 
		{
			TestPlayer modOther = other.GetModPlayer<TestPlayer>();
			return ZoneCrystalMines == modOther.ZoneCrystalMines;
			// If you have several Zones, you might find the &= operator or other logic operators useful:
			// bool allMatch = true;
			// allMatch &= ZoneCrystalMines == modOther.ZoneCrystalMines;
			// allMatch &= ZoneModel == modOther.ZoneModel;
			// return allMatch;
			// Here is an example just using && chained together in one statemeny 
			// return ZoneCrystalMines == modOther.ZoneCrystalMines && ZoneModel == modOther.ZoneModel;
		}
		
		public override void CopyCustomBiomesTo(Player other) 
		{
			TestPlayer modOther = other.GetModPlayer<TestPlayer>();
			modOther.ZoneCrystalMines = ZoneCrystalMines;
		}

		public override void SendCustomBiomes(BinaryWriter writer) 
		{
			BitsByte flags = new BitsByte();
			flags[0] = ZoneCrystalMines;
			writer.Write(flags);
		}

		public override void ReceiveCustomBiomes(BinaryReader reader) 
		{
			BitsByte flags = reader.ReadByte();
			ZoneCrystalMines = flags[0];
		}
		
		public override Texture2D GetMapBackgroundImage() 
		{
			if (ZoneCrystalMines) {
				return mod.GetTexture("CrystalMinesBackground");
			}
			return null;
		}
		// koniec biome shitz, doesnt work for some fucking reason, none of it ^
		
		private const int saveVersion = 0;
        public bool GraniteDrone = false;
		public bool FriendlyProbe = false;
        public static bool hasProjectile;
 
        public override void ResetEffects()
        {
            GraniteDrone = false;
			FriendlyProbe = false;
        }
		
		public override void CatchFish(Item fishingRod, Item bait, int power, int liquidType, int poolSize, int worldLayer, int questFish, ref int caughtType, ref bool junk) 
		{
			if (junk) 
			{
				return;
			}
			if (player.ZoneGlowshroom && liquidType == 0 && Main.rand.NextBool(3)) 
			{
				caughtType = ModContent.ItemType<ManaLeech>();
			}
		}
	}
}