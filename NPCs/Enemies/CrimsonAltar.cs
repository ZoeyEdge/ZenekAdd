using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.NPCs.Enemies
{
	public class CrimsonAltar : ModNPC
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Altar of Crimson");
		}

		public override void SetDefaults()
		{
			npc.width = 40;
			npc.height = 44;
			npc.damage = 5;
			npc.defense = 0;
			npc.lifeMax = 75;
			npc.HitSound = SoundID.NPCHit18;
			npc.DeathSound = SoundID.NPCDeath21;
			npc.value = 60f;
			npc.knockBackResist = 0f;
			npc.aiStyle = 73;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
			if (spawnInfo.player.ZoneCrimson)
                return 0.2f;
			return 0f;
        }
	   
       public override void NPCLoot()
       {
	        if (Main.rand.Next(5) == 0)
	        Item.NewItem(npc.getRect(), mod.ItemType ("CrimsonRuby"));
       }
	}
}