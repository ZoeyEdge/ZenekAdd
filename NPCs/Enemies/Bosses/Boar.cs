using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.NPCs.Enemies.Bosses
{
	public class Boar : ModNPC
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("The BOAR God");
		}

		public override void SetDefaults()
		{
			npc.width = 255;
			npc.height = 255;
			npc.boss = true;
			npc.lavaImmune = true;
			npc.knockBackResist = 0f;
			npc.damage = 999;
			npc.defense = 0;
			npc.lifeMax = 77777;
			npc.aiStyle = 69;
			npc.HitSound = SoundID.NPCHit14;
			npc.DeathSound = SoundID.NPCDeath20;
			//music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/BoarTheme");
		}
		
		public override void NPCLoot()
        {
	     Item.NewItem(npc.getRect(), mod.ItemType("DumShard"));
        }
	}
}