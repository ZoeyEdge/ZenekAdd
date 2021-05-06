using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Scrapped
{
	public class Candior3 : ModNPC
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Candior");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Pixie];
		}

		public override void SetDefaults()
		{
			npc.width = 20;
			npc.height = 18;
			npc.damage = 20;
			npc.defense = 3;
			npc.lifeMax = 600;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath16;
			npc.value = 5000;
			npc.knockBackResist = 0.3f;
			npc.noGravity = true;
			npc.noTileCollide = true;
			npc.aiStyle = 63;
			animationType = NPCID.Pixie;
			music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/CandiorTheme");
			// SCRAPPED HALLOWEEN BOSS, DOESNT SPLIT LIKE I WANTED IT TO
		}
	}
}