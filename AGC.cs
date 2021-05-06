using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.NPCs.Enemies.Bosses
{
	public class AGC : ModNPC
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("A.G.C.");
		}

		public override void SetDefaults()
		{
			npc.width = 264;
			npc.height = 144;
			npc.boss = true;
			npc.lavaImmune = true;
			npc.knockBackResist = 1f;
			npc.damage = 0;
			npc.defense = 10;
			npc.lifeMax = 12000;
			npc.aiStyle = 0;
			npc.HitSound = SoundID.NPCHit4;
			npc.DeathSound = SoundID.NPCDeath14;
			music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/AGCTheme");
		}
		
		public override void NPCLoot()
        {
	     Item.NewItem(npc.getRect(), mod.ItemType("DumShard"));
        }
	}
}