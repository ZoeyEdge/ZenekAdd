using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.NPCs.Enemies
{
	public class MushyZombie : ModNPC
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Mushy Zombie");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
		}

		public override void SetDefaults()
		{
			npc.width = 45;
			npc.height = 45;
			npc.damage = 15;
			npc.defense = 2;
			npc.lifeMax = 200;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 60f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 3;
			aiType = NPCID.Zombie;
			animationType = NPCID.Zombie;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
       {
	        if (spawnInfo.player.ZoneOverworldHeight && !Main.dayTime) 
                return 0.1f; 
            return 0f; 
       }
	   
       public override void NPCLoot()
       {
	        if (Main.rand.NextFloat() < .5500f)
	            Item.NewItem(npc.getRect(), mod.ItemType ("StinkShroom"));
       }
	}
}