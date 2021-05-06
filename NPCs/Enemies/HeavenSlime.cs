using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.NPCs.Enemies
{
	public class HeavenSlime : ModNPC
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Winged Heavenly Slime");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Slimer];
		}

		public override void SetDefaults()
		{
			npc.width = 42;
			npc.height = 34;
			npc.damage = 10;
			npc.defense = 2;
			npc.lifeMax = 50;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.aiStyle = 14;
			npc.noGravity = true;
	        aiType = NPCID.Slimer;
			animationType = NPCID.Slimer;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
	       return SpawnCondition.Sky.Chance * 1f;
		}
	}
}