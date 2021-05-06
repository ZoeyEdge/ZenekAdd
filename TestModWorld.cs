using System.IO;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Generation;
using System.Linq;
 
 
namespace ZenekAdd
{
    public class TestModWorld : ModWorld
    {
        /* Dont generate the world, it's in heavy testing
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int genIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            if (genIndex == -1)
            {
                return;
            }
            tasks.Insert(genIndex + 1, new PassLegacy("Crystal Mines", delegate (GenerationProgress progress)
            {
                progress.Message = "Haunting some crystals";
                for (int i = 0; i < Main.maxTilesX / 4000; i++)  //900 is how many biomes there are. the bigger is the number = less biomes
                {
                    int X = WorldGen.genRand.Next(1, Main.maxTilesX - 300);
                    int Y = WorldGen.genRand.Next((int)WorldGen.rockLayer - 100, Main.maxTilesY - 200);
                    int TileType = 418; //this is the tile u want to use for the biome, if u want to use a vanilla tile then its int TileType = 56; 56 is obsidian block
 
                    WorldGen.TileRunner(X, Y, 500, WorldGen.genRand.Next(200, 300), TileType, false, 0f, 0f, true, true);  //350 is how big is the biome  100, 200 this changes how random it looks.
 
                }
 
            }));
        }
		*/ 
    }
}