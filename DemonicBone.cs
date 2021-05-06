using ZenekAdd;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ZenekAdd.NPCs.Enemies.Bosses;
using static Terraria.ModLoader.ModContent;

namespace ZenekAdd.Items
{
	public class DemonicBone : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Demonic Bone");
			Tooltip.SetDefault("May summon a big hellish doggo");
			ItemID.Sets.SortingPriorityBossSpawns[item.type] = 13; // This helps sort inventory know this is a boss summoning item.
		}

		public override void SetDefaults() 
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 5;
			item.rare = 2;
			item.useAnimation = 45;
			item.useTime = 45;
			item.useStyle = ItemUseStyleID.HoldingUp;
			item.UseSound = SoundID.Item44;
			item.consumable = true;
		}
		
		// We use the CanUseItem hook to prevent a player from using this item while the boss is present in the world.
		public override bool CanUseItem(Player player) 
		{
			// "player.ZoneOverworldHeight" could also be written as "player.position.Y / 16f > Main.maxTilesY - 200"
			return player.ZoneOverworldHeight && !NPC.AnyNPCs(NPCType<Khaar>());
		}

		public override bool UseItem(Player player) 
		{
			NPC.SpawnOnPlayer(player.whoAmI, NPCType<KhaarHead>());
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
		
		public override void AddRecipes() 
		{
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bone, 50);
			recipe.AddIngredient(ItemID.Obsidian, 5);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}