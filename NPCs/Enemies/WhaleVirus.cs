using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.NPCs.Enemies
{
	public class WhaleVirus : ModNPC
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Whale Virus");
		}

		public override void SetDefaults()
		{
			npc.width = 46;
			npc.height = 28;
			npc.damage = 20;
			npc.defense = 15;
			npc.lifeMax = 600;
			npc.knockBackResist = 1f;
			npc.aiStyle = 1;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
       {
	        if (spawnInfo.player.ZoneOverworldHeight && NPC.AnyNPCs(mod.NPCType("AGC")))
                return 1f;
			return 0f;

       }
	}
}