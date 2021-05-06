using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Scrapped
{
	public class Cando : ModNPC
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Cando");
		}

		public override void SetDefaults()
		{
			npc.width = 22;
			npc.height = 12;
			npc.damage = 5;
			npc.defense = 1;
			npc.lifeMax = 15;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath16;
			npc.value = 1f;
			npc.knockBackResist = 2f;
			npc.noGravity = true;
			npc.aiStyle = 5; 
			aiType = NPCID.BeeSmall;
			// MINION OF CANDIOR
		}

       //public override void NPCLoot()
        //{ WHY IS THIS EVEN HERE
			//if (Main.rand.Next(5) == 0)
	        //Item.NewItem(npc.getRect(), mod.ItemType ("GranitePowerCell"));
        //}
	}
}