using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Scrapped
{
	public class Candior2 : ModNPC
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Candior");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.BlueSlime];
		}

		public override void SetDefaults()
		{
			npc.width = 22;
			npc.height = 6;
			npc.damage = 25;
			npc.defense = 4;
			npc.lifeMax = 1000;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath16;
			npc.value = 10000;
			npc.knockBackResist = 0.4f;
			npc.noGravity = true;
			npc.noTileCollide = true;
			npc.aiStyle = 5;
			aiType = NPCID.Corruptor;
			animationType = NPCID.BlueSlime;
			music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/CandiorTheme");
			// SCRAPPED HALLOWEEN BOSS, DOESNT SPLIT LIKE I WANTED IT TO
		}
		
		public virtual void NPCLoot()
        {
            NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, (int)mod.NPCType("Candior3"));
            NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, (int)mod.NPCType("Candior3"));
			NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, (int)mod.NPCType("Candior3"));
			NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, (int)mod.NPCType("Candior3"));
        }
	}
}