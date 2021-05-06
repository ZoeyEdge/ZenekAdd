using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.NPCs.Enemies
{
	public class SpaceJelly : ModNPC
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Starlit-jelly");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.BlueSlime];
		}

		public override void SetDefaults()
		{
			npc.width = 40;
			npc.height = 40;
			npc.damage = 12;
			npc.defense = 1;
			npc.lifeMax = 25;
			npc.HitSound = SoundID.NPCHit25;
			npc.DeathSound = SoundID.NPCDeath28;
			npc.aiStyle = 14;
			npc.noGravity = true;
			npc.noTileCollide = true;
	        aiType = NPCID.Slimer;
			animationType = NPCID.BlueSlime;
		}
	}
}