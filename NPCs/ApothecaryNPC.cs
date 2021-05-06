using System;
using System.Collections.Generic;
using System.Linq;
using ZenekAdd;
using ZenekAdd.Items;
using ZenekAdd.Tiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using ZenekAdd.Projectiles;
using static Terraria.ModLoader.ModContent;

namespace ZenekAdd.NPCs
{
	// [AutoloadHead] and npc.townNPC are extremely important and absolutely both necessary for any Town NPC to work at all.
	[AutoloadHead]
	public class ApothecaryNPC : ModNPC
	{
		public override string Texture => "ZenekAdd/NPCs/ApothecaryNPC";

		public override bool Autoload(ref string name) 
		{
			name = "Apothecary";
			return mod.Properties.Autoload;
		}

		public override void SetStaticDefaults() 
		{
			// DisplayName automatically assigned from .lang files, but the commented line below is the normal approach.
			// DisplayName.SetDefault("Apothecary");
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Guide];
		}

		public override void SetDefaults() 
		{
			npc.townNPC = true;
			npc.friendly = true;
			npc.width = 18;
			npc.height = 40;
			npc.aiStyle = 7;
			npc.damage = 10;
			npc.defense = 15;
			npc.lifeMax = 500;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.knockBackResist = 0.5f;
			animationType = NPCID.Guide;
		}

		public override bool CanTownNPCSpawn(int numTownNPCs, int money) 
		{
			for (int k = 0; k < 255; k++) 
			{
				Player player = Main.player[k];
				if (!player.active) 
				{
					continue;
				}

				foreach (Item item in player.inventory) 
				{
					if (item.type == ModContent.ItemType<PoorWhiskey>())
					{
						return true;
					}
				}
			}
			return false;
		}

		public override string TownNPCName() 
		{
			switch (WorldGen.genRand.Next(14)) 
			{
				case 0:
					return "Garry";
				case 1:
					return "Brad";
				case 2:
					return "Doug";
				case 3:
				    return "Bill";
				case 4:
				    return "Jonh";
				case 5:
				    return "Bart";
				case 6:
				    return "Brendon";
				case 7:
				    return "Ferdinand";
				case 8:
				    return "Robert";
				case 9:
				    return "Mark";
				case 10:
				    return "Thomas";
				case 11:
				    return "Tim";
				case 12:
				    return "Steve";
				default:
					return "Frank";
			}
		}

		public override void FindFrame(int frameHeight) 
		{
			/*npc.frame.Width = 40;
			if (((int)Main.time / 10) % 2 == 0)
			{
				npc.frame.X = 40;
			}
			else
			{
				npc.frame.X = 0;
			}*/
		}

		public override string GetChat() 
		{
			int partyGirl = NPC.FindFirstNPC(NPCID.PartyGirl);
			if (partyGirl >= 0 && Main.rand.NextBool(4)) 
			{
				return "Can you please tell " + Main.npc[partyGirl].GivenName + " to stop decorating my house with colors?";
			} 
			switch (Main.rand.Next(7)) 
			{
				case 0:
					return "Do you people actually like your job?";
				case 1:
					return "What's your favorite color? My favorite colors are white and black.";
				case 2:
                    return "Why do we need the money anyways?";
			    case 3: 
				    return "Hello and welcome! Buy something and leave me alone.";
				case 4:
					return "I have a question for god...";
			    case 5:
				    return "You know what scares me? Some people ACTUALLY enjoy thier lifes!";
				default:
					return "Another day in this world is -1 to my 'will to live' stat.";
			}
		}

		/* 
		// Consider using this alternate approach to choosing a random thing. Very useful for a variety of use cases.
		// The WeightedRandom class needs "using Terraria.Utilities;" to use
		public override string GetChat()
		{
			WeightedRandom<string> chat = new WeightedRandom<string>();
			int partyGirl = NPC.FindFirstNPC(NPCID.PartyGirl);
			if (partyGirl >= 0 && Main.rand.NextBool(4))
			{
				chat.Add("Can you please tell " + Main.npc[partyGirl].GivenName + " to stop decorating my house with colors?");
			}
			chat.Add("Sometimes I feel like I'm different from everyone else here.");
			chat.Add("What's your favorite color? My favorite colors are white and black.");
			chat.Add("What? I don't have any arms or legs? Oh, don't be ridiculous!");
			chat.Add("This message has a weight of 5, meaning it appears 5 times more often.", 5.0);
			chat.Add("This message has a weight of 0.1, meaning it appears 10 times as rare.", 0.1);
			return chat; // chat is implicitly cast to a string. You can also do "return chat.Get();" if that makes you feel better
		}
		*/
		public override void SetChatButtons(ref string button, ref string button2) 
		{
			button = Language.GetTextValue("LegacyInterface.28");
		}
		
		public override void OnChatButtonClicked(bool firstButton, ref bool shop) 
		{
			if (firstButton) 
			{
				shop = true;
			}
		}

		public override void SetupShop(Chest shop, ref int nextSlot) 
		{
			shop.item[nextSlot].SetDefaults(ItemID.LesserHealingPotion);
			shop.item[nextSlot].shopCustomPrice = 500;
			nextSlot++;
			
			shop.item[nextSlot].SetDefaults(ItemID.LesserManaPotion);
			shop.item[nextSlot].shopCustomPrice = 500;
			nextSlot++;
			
			shop.item[nextSlot].SetDefaults(ItemID.HealingPotion);
			shop.item[nextSlot].shopCustomPrice = 1000;
			nextSlot++;
			
			shop.item[nextSlot].SetDefaults(ItemID.ManaPotion);
			shop.item[nextSlot].shopCustomPrice = 1000;
			nextSlot++;
			
			shop.item[nextSlot].SetDefaults(ItemID.LesserRestorationPotion);
			shop.item[nextSlot].shopCustomPrice = 1525;
			nextSlot++;
			
			shop.item[nextSlot].SetDefaults(ItemID.RestorationPotion);
			shop.item[nextSlot].shopCustomPrice = 3500;
			nextSlot++;
			
			shop.item[nextSlot].SetDefaults(ItemID.ManaRegenerationPotion);
			shop.item[nextSlot].shopCustomPrice = 8500;
			nextSlot++;
			
			shop.item[nextSlot].SetDefaults(ItemID.HeartreachPotion);
			shop.item[nextSlot].shopCustomPrice = 8500;
			nextSlot++;
			
			shop.item[nextSlot].SetDefaults(ItemID.CalmingPotion);
			shop.item[nextSlot].shopCustomPrice = 10000;
			nextSlot++;
			
			shop.item[nextSlot].SetDefaults(ItemID.LifeforcePotion);
			shop.item[nextSlot].shopCustomPrice = 50000;
			nextSlot++;
		}
		
		public override bool CanGoToStatue(bool toKingStatue) 
		{
			return true;
		}
		
		public override void TownNPCAttackStrength(ref int damage, ref float knockback) 
		{
			damage = 20;
			knockback = 4f;
		}

		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown) 
		{
			cooldown = 30;
			randExtraCooldown = 30;
		}

		public override void TownNPCAttackProj(ref int projType, ref int attackDelay) 
		{
			projType = ProjectileType<Bubble>();
			attackDelay = 1;
		}

		public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset) 
		{
			multiplier = 12f;
			randomOffset = 2f;
		}
	}
}