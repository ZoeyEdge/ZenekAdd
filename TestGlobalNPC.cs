using ZenekAdd;
using ZenekAdd.Items;
using ZenekAdd.Items.Accessory;
using ZenekAdd.Tiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd
{
	public class TestGlobalNPC : GlobalNPC
	{
		public override void SetupShop(int type, Chest shop, ref int nextSlot) 
		{
			if (type == NPCID.ArmsDealer) 
			{
				shop.item[nextSlot].SetDefaults(ModContent.ItemType<EmptyCasing>());
				shop.item[nextSlot].shopCustomPrice = 10000;
				nextSlot++;	
			}
		}
		
	    public override void NPCLoot(NPC npc)
	    {
		    if(npc.type == NPCID.ZombieEskimo)
		    {
			    if (Main.rand.NextFloat() < .1000f)
				    Item.NewItem(npc.getRect(), mod.ItemType("PoorWhiskey"));
		    }
			
			if(npc.type == NPCID.GraniteGolem)
			{
				if (Main.rand.NextFloat() < .3000f)
	                Item.NewItem(npc.getRect(), mod.ItemType ("GranitePowerCell"));
			}
				
			if(npc.type == NPCID.GraniteFlyer)
			{
				if (Main.rand.NextFloat() < .5000f)
	                Item.NewItem(npc.getRect(), mod.ItemType ("GranitePowerCell"));
			}
			
			if(npc.type == NPCID.CataractEye + NPCID.SleepyEye + NPCID.DialatedEye + NPCID.GreenEye + NPCID.PurpleEye + NPCID.DemonEye2 + NPCID.PurpleEye2 + NPCID.GreenEye2 + NPCID.DialatedEye2 + NPCID.SleepyEye2 + NPCID.CataractEye2 + NPCID.DemonEye + NPCID.DemonEyeOwl + NPCID.DemonEyeSpaceship + NPCID.ServantofCthulhu)
			{
				if (Main.rand.NextFloat() < .0003f)
	                Item.NewItem(npc.getRect(), mod.ItemType ("WatchfulEye"));
			}
			
			if(npc.type == NPCID.EyeofCthulhu)
			{
				if (Main.rand.NextFloat() < .2500f)
	                Item.NewItem(npc.getRect(), mod.ItemType ("WatchfulEye"));
			}
			
			if (npc.type == NPCID.TheDestroyer)
			{
				if (Main.rand.NextFloat() < .5000f)
	                Item.NewItem(npc.getRect(), mod.ItemType ("ProbeCaller"));
			}
			
			if (npc.type == NPCID.TheDestroyer)
			{
				if (Main.rand.NextFloat() < .5000f)
	                Item.NewItem(npc.getRect(), mod.ItemType ("ProbeCaller"));
			}
			
			if (npc.type == NPCID.PigronCorruption + NPCID.PigronHallow + NPCID.PigronCrimson + NPCID.SnowmanGangsta + NPCID.ToxicSludge + NPCID.Sharkron)
			{
				if (Main.rand.NextFloat() < .0001f)
	                Item.NewItem(npc.getRect(), mod.ItemType ("StalePizza"));
			}
			
			if (npc.type == NPCID.ArmoredSkeleton)
			{
				if (Main.rand.NextFloat() < .3000f)
	                Item.NewItem(npc.getRect(), mod.ItemType ("Equalizer"));
			}
			
			if (npc.type == NPCID.Snatcher)
			{
				if (Main.rand.NextFloat() < .2500f)
	                Item.NewItem(npc.getRect(), mod.ItemType ("SolarFlower"));
			}
			
			if (npc.type == NPCID.Guide)
			{
				if (Main.rand.NextFloat() < .0001f)
	                Item.NewItem(npc.getRect(), mod.ItemType ("Strawberry"));
			}
			
			if (npc.type == NPCID.Antlion + NPCID.WalkingAntlion + NPCID.FlyingAntlion)
			{
				if (Main.rand.NextFloat() < .0500f)
	                Item.NewItem(npc.getRect(), mod.ItemType ("HuntressGlaive"));
			}
	    }
	}
}