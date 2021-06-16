using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.NPCs.Enemies.Bosses
{
	public class Jellyfish : ModNPC
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Stellar Jellyfish");
		}

		public override void SetDefaults()
		{
			npc.width = 100;
			npc.height = 100;
			npc.boss = true;
			npc.lavaImmune = true;
			npc.knockBackResist = 0f;
			npc.damage = 50;
			npc.defense = 5;
			npc.lifeMax = 5000;
			npc.aiStyle = 87; 
			aiType = NPCID.BigMimicCrimson; // for now
			npc.HitSound = SoundID.NPCHit25;
			npc.DeathSound = SoundID.NPCDeath28;
			music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/JellyfishTheme");
		}
		
		public override void NPCLoot()
        {
	     Item.NewItem(npc.getRect(), mod.ItemType("DumShard"));
        }
	}
}