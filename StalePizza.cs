using ZenekAdd;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ZenekAdd.NPCs.Enemies.Bosses;
using static Terraria.ModLoader.ModContent;

namespace ZenekAdd.Items
{
	public class StalePizza : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stale Pizza");
			Tooltip.SetDefault("Atleast it's without pineapples... right?");
			ItemID.Sets.SortingPriorityBossSpawns[item.type] = 13; // This helps sort inventory know this is a boss summoning item.
		}

		public override void SetDefaults() 
		{
			item.width = 28;
			item.height = 26;
			item.maxStack = 1;
			item.rare = -1;
			item.useAnimation = 50;
			item.useTime = 50;
			item.useStyle = ItemUseStyleID.HoldingUp;
			item.UseSound = SoundID.Item44;
			item.consumable = true;
		}
		
		// We use the CanUseItem hook to prevent a player from using this item while the boss is present in the world.
		public override bool CanUseItem(Player player) 
		{
			// "player.ZoneOverworldHeight" could also be written as "player.position.Y / 16f > Main.maxTilesY - 200"
			return player.ZoneOverworldHeight && !NPC.AnyNPCs(NPCType<Boar>());
		}

		public override bool UseItem(Player player) 
		{
			NPC.SpawnOnPlayer(player.whoAmI, NPCType<Boar>());
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}