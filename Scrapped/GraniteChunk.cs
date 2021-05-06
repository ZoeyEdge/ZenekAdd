using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;

namespace ZenekAdd.Scrapped
{
	public class GraniteChunk : ModNPC
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Granite Chunk");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.MeteorHead];
		}

		public override void SetDefaults()
		{
			npc.width = 26;
			npc.height = 26;
			npc.damage = 20;
			npc.defense = 25;
			npc.lifeMax = 30;
			npc.noGravity = true;
			npc.noTileCollide = true;
			npc.lavaImmune = true;
			npc.HitSound = SoundID.NPCHit3;
			npc.DeathSound = SoundID.NPCDeath3;
			npc.value = 20f;
			npc.knockBackResist = 0f;
			npc.aiStyle = 5;
			aiType = NPCID.MeteorHead;
			animationType = NPCID.MeteorHead;
			// SCRAPPED GRANITE BIOME ENEMY, ANNOYING AND DUST IS DUMB.
		}

	   /*public override float SpawnChance(NPCSpawnInfo spawnInfo)
        *{
	    *    if (spawnInfo.granite)
        *        return 0.2f;
        *    return 0f;
       */
	   
       public override void NPCLoot() 
        {
			if (Main.rand.NextFloat() < .6000f)
	            Item.NewItem(npc.getRect(), mod.ItemType ("GranitePowerCell"));
        }
	}
}