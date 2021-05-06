using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.NPCs.Enemies
{
	public class GraniteInsect : ModNPC 
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Granite Insect");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.StardustSpiderBig];
		}

		public override void SetDefaults()
		{
			npc.width = 34; 
			npc.height = 42; 
			npc.damage = 30; 
			npc.defense = 10; 
			npc.lifeMax = 55; 
			npc.HitSound = SoundID.NPCHit6; 
			npc.DeathSound = SoundID.NPCDeath1; 
			npc.value = 60f; 
			npc.knockBackResist = 0.6f; 
			npc.aiStyle = 3; 
			aiType = NPCID.Zombie; 
			animationType = NPCID.StardustSpiderBig; 
		}

	   public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
	        if (spawnInfo.granite) 
                return 0.2f; 
            return 0f; 
        }
	   
       public override void NPCLoot() 
        {
			if (Main.rand.NextFloat() < .1500f)
	            Item.NewItem(npc.getRect(), mod.ItemType ("GranitePowerCell"));
        }
	} 
}