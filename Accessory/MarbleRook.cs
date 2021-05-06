using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace ZenekAdd.Items.Accessory
{
	public class MarbleRook : ModItem
	{
		public override void SetStaticDefaults() 
		{
			Tooltip.SetDefault("Increased enemy aggro, +25 HP and +2 DEF"
			+ "\nNo, this is not a castle");
		}

		public override void SetDefaults() 
		{
			item.width = 33;
			item.height = 45;
			item.accessory = true;
			item.value = Item.sellPrice(silver: 65);
			item.rare = 2;
		}
		
		public override void UpdateEquip(Player player) 
		{
			player.statLifeMax2 += 25;
			player.statDefense += 2;
			player.aggro += 200;
		}
		
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MarbleBlock, 30);
			recipe.AddTile(TileID.HeavyWorkBench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}