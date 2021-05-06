using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.NPCs.Enemies
{
	public class GraniteScorpion : ModNPC 
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Granite Scorpion");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.DesertScorpionWalk];
		}

		public override void SetDefaults()
		{
			npc.width = 50; 
			npc.height = 20; 
			npc.damage = 50; 
			npc.defense = 3; 
			npc.lifeMax = 120; 
			npc.HitSound = SoundID.NPCHit13; 
			npc.DeathSound = SoundID.NPCDeath19;
			npc.value = 60f; 
			npc.knockBackResist = 0.8f; 
			npc.aiStyle = 3; 
			aiType = NPCID.Zombie; 
			animationType = NPCID.DesertScorpionWalk; 
		}

	   public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
	        if (spawnInfo.granite) 
                return 0.2f; 
            return 0f; 
        }
	   
       public override void NPCLoot() 
        {
			if (Main.rand.NextFloat() < .3000f)
	            Item.NewItem(npc.getRect(), mod.ItemType ("GranitePowerCell"));
        }
	} 
}