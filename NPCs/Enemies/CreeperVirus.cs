using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.NPCs.Enemies
{
	public class CreeperVirus : ModNPC
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Creeper Virus");
		}

		public override void SetDefaults()
		{
			npc.width = 44;
			npc.height = 44;
			npc.damage = 25;
			npc.defense = 3;
			npc.lifeMax = 455;
			npc.aiStyle = 5;
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