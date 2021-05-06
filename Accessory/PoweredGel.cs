using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace ZenekAdd.Items.Accessory
{
	public class PoweredGel : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("+20 mana"
			+ "\nGel powered by a mana star");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.accessory = true;
			item.value = Item.sellPrice(silver: 5);
			item.rare = 1;
		}
		
		public override void UpdateEquip(Player player) 
		{
			player.statManaMax2 += 20;
		}
		
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 5);
			recipe.AddIngredient(ItemID.ManaCrystal, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}