using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.NPCs.Enemies
{
	public class GraniteBeetle : ModNPC
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Granite Beetle");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.CochinealBeetle];
		}

		public override void SetDefaults()
		{
			npc.width = 32;
			npc.height = 22;
			npc.damage = 10;
			npc.defense = 7;
			npc.lifeMax = 120;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath16;
			npc.value = 30f;
			npc.knockBackResist = 2f;
			npc.aiStyle = 3;
			aiType = NPCID.Zombie;
			animationType = NPCID.CochinealBeetle;
		}

	   public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
	        if (spawnInfo.granite)
                return 0.2f;
            return 0f;
        }
	   
       public override void NPCLoot()
        {
			if (Main.rand.Next(5) == 0)
	        Item.NewItem(npc.getRect(), mod.ItemType ("GranitePowerCell"));
        }
	}
}