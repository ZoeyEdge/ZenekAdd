using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class MushroomArmorGreaves : ModItem
	{
		public override void SetStaticDefaults() 
		{
			Tooltip.SetDefault("Quite literally Foot Fungus");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = Item.sellPrice(silver: 2);
			item.rare = 1;
			item.defense = 2;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Mushroom, 5);
			recipe.AddIngredient(ItemID.WoodGreaves);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}