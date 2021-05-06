using ZenekAdd.Tiles;
using ZenekAdd;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.GameContent.Dyes;
using Terraria.GameContent.UI;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;
using static Terraria.ModLoader.ModContent;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using static Terraria.ModLoader.MusicPriority;

namespace ZenekAdd
{
	public class TestMod : Mod
	{
		
	    public override void Load()
        {
			/*
            if (!Main.dedServ) 
			{ // do not run this code on the server
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/KhaarTheme"), ItemType("KhaarMusicBox"), TileType("KhaarMusicBox"));
            }*/
        }
		/*
		public override void UpdateMusic(ref int music, ref MusicPriority priority)
        {
            if (Main.myPlayer != -1 && !Main.gameMenu)
            {
                if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].GetModPlayer<TestPlayer>().ZoneCrystalMines) //this makes the music play only in Custom Biome
                {
                    music = this.GetSoundSlot(SoundType.Music, "Sounds/Music/CrystalMines");  //add where is the custom music is located
					priority = BiomeHigh;
                }
            }
        }*/
		
        public static int ZoneCrystalMinesTiles = 0;

        public virtual void TileCountsAvailable(int[] tileCounts)
        {
            ZoneCrystalMinesTiles = tileCounts[418];  //+ tileCounts[ModContent.TileType<MyMod.Tiles.NewTile2>()] ;
        }
	}
}