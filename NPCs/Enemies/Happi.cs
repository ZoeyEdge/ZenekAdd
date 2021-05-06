using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.NPCs.Enemies
{
	public class Happi : ModNPC
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Happi");
		}

		public override void SetDefaults()
		{
			npc.width = 32;
			npc.height = 32;
			npc.damage = 10;
			npc.defense = 2;
			npc.lifeMax = 50;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.aiStyle = 10;
			npc.noGravity = true;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
	        if (spawnInfo.player.ZoneOverworldHeight && Main.dayTime) 
                return 0.1f; 
            return 0f; 
       	}
		
        public override void NPCLoot()
        {
	        Item.NewItem(npc.getRect(), mod.ItemType("DumShard"));
        }
	}
}