using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class GelArmorBreastplace : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Gel Breastplate");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = Item.sellPrice(silver: 9);
			item.rare = 1;
			item.defense = 2;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 50);
			recipe.AddIngredient(ItemID.StoneBlock, 7);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}