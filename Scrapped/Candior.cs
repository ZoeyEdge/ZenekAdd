using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Scrapped
{
	public class Candior : ModNPC
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Candior");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Pixie];
		}

		public override void SetDefaults()
		{
			npc.width = 84;
			npc.height = 48;
			npc.damage = 30;
			npc.defense = 5;
			npc.lifeMax = 1500;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath16;
			npc.value = 155000;
			npc.knockBackResist = 0.5f;
			npc.noGravity = true;
			npc.noTileCollide = true;
			npc.aiStyle = 5;
			aiType = NPCID.Corruptor;
			animationType = NPCID.Pixie;
			//music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/CandiorTheme");
			// SCRAPPED HALLOWEEN BOSS, DOESNT SPLIT LIKE I WANTED IT TO
		}

		public virtual void NPCLoot()
        {
            NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, (int)mod.NPCType("Candior2"));
            NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, (int)mod.NPCType("Candior2"));
        }
	}
}