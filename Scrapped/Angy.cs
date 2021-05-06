using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Scrapped
{
	public class Angy : ModNPC
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Angy");
		}

		public override void SetDefaults()
		{
			npc.width = 62;
			npc.height = 62;
			npc.boss = true;
			npc.lavaImmune = true;
			npc.noTileCollide = true;
			npc.damage = 20;
			npc.defense = 2;
			npc.lifeMax = 1200;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.aiStyle = 30;
			npc.noGravity = true;
			// SCRAPPED VERY-EARLY TEST BOSS TO TEST HOW BOSSES WORK
		}
		public override void NPCLoot()
        {
	     Item.NewItem(npc.getRect(), mod.ItemType("DumShard"));
        }
	}
}