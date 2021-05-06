using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class LeafyArmorBoots : ModItem
	{
		public override void SetStaticDefaults() 
		{
            DisplayName.SetDefault("Leafy Boots");
		}

		public override void SetDefaults() 
		{
			item.width = 22;
			item.height = 18;
			item.value = Item.sellPrice(silver: 2);
			item.rare = 1;
			item.defense = 1;
		}
		
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 23);
			recipe.AddIngredient(ItemID.Acorn, 3);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}