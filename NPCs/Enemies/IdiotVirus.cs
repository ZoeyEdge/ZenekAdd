using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.NPCs.Enemies
{
	public class IdiotVirus : ModNPC
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Idiot Virus");
		}

		public override void SetDefaults()
		{
			npc.width = 40;
			npc.height = 40;
			npc.damage = 40;
			npc.defense = 5;
			npc.lifeMax = 400;
			npc.aiStyle = 63;
			npc.noGravity = true;
			npc.noTileCollide = true;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
       {
	        if (spawnInfo.player.ZoneOverworldHeight && NPC.AnyNPCs(mod.NPCType("AGC")))
                return 1f;
			return 0f;

       }
	}
}